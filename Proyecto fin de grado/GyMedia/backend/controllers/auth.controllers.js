import User from "../models/userSchema.js";
import jwt from "jsonwebtoken";
import config from "../src/config.js";

export const signUp = async (req, res) => {
  const { username, email, password } = req.body;
  const encryptedPassword = await User.encryptPassword(password);

  const newUser = new User({
    username,
    email,
    password: encryptedPassword,
    image: "http://127.0.0.1:6001/assets/UsersImage/defaultProfile.png",
    background_image: "",
    fullname: "User-" + Math.floor(Math.random() * 10000000),
    address: "Este usuario no ha especificado su dirección",
    job: "Este usuario no ha especificado su trabajo",
    studies: "Este usuario no ha especificado sus estudios",
    description: "Este usuario no posee descripción",
    list: [],
  });

  const savedUser = await newUser.save();

  const token = jwt.sign({ id: savedUser._id }, config.SECRET, {
    expiresIn: 86400, //24 hours
  });
  res.set("Authorization", `Bearer ${token}`);
  res.json({ token: token });
};
export const signIn = async (req, res) => {
  const userFound = await User.findOne({ email: req.body.email });
  const expired = req.body.remember;
  if (!userFound)
    return res.status(401).json({
      token: null,
      message: "El usuario o la contraseña no son correctos",
    });

  const matchPassword = await User.comparePassword(
    req.body.password,
    userFound.password
  );

  if (!matchPassword)
    return res.status(401).json({
      token: null,
      message: "El usuario o la contraseña no son correctos",
    });

  let token;
  if (expired) {
    token = jwt.sign({ id: userFound._id }, config.SECRET);
  } else {
    token = jwt.sign({ id: userFound._id }, config.SECRET, {
      expiresIn: 86400,
    });
  }

  res.set("Authorization", `Bearer ${token}`);
  res.json({ token: token });
};

export const getUserByToken = async (req, res) => {
  const { token } = req.body;
  try {
    if (token == null) {
      console.log("Se buggeo esto wey");
    } else {
      const decoded = jwt.verify(token, config.SECRET);
      const userFound = await User.findById(decoded.id);
      return res.status(200).json({ userFound });
    }
  } catch (error) {
    return res.status(404).json({ message: "Token can not be decoded" });
  }
};
