import React from "react";
import ChangePasswordForm from "./ChangePasswordForm";
import Toggle from "./Toggle";
import UploadFile from "../../UploadFiles/UploadFile";
import AvatarUpload from "../../UploadFiles/AvatarUpload";
import { UserContext } from "../../../Context/UserContext";
import { useContext, useState, useEffect } from "react";
import { AuthContext } from "../../../Context/AuthContext";

export default function EditProfile() {
  const { getUserInfo } = useContext(UserContext);
  const [userInfo, setUserInfo] = useState([]);
  const { getUserByToken, token } = useContext(AuthContext);
  useEffect(() => {
    async function getInfo() {
      const userFound = await getUserByToken(token);
      const user = userFound.userFound;
      let userInfo;
      userInfo = await getUserInfo(user._id);
      setUserInfo(userInfo);
    }
    getInfo();
  }, []);

  const [fullname, setFullname] = useState(userInfo.fullname);
  const [address, setAddress] = useState(userInfo.address);
  const [description, setDescription] = useState(userInfo.description);
  const [job, setJob] = useState(userInfo.job);
  const [studies, setStudies] = useState(userInfo.studies);

  const handleClick = async () => {
    try {
      const response = await fetch("http://127.0.0.1:6001/api/user/edit", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(user),
      });

      const data = await response.json();
      return data;
    } catch (error) {
      return false;
    }
  };

  const handleChange = (e) => {
    setFullname(e.target.value);
  };
  const handleChangeAddress = (e) => {
    setAddress(e.target.value);
  };
  const handleChangeJob = (e) => {
    setJob(e.target.value);
  };
  const handleChangeStudies = (e) => {
    setStudies(e.target.value);
  };
  const handleChangeDescription = (e) => {
    setDescription(e.target.value);
  };
  return (
    <>
      <div className="max-w-3xl mx-auto mt-10 grid grid-cols-1 md:grid-cols-2 gap-8">
        <div className="bg-white p-6 rounded-md shadow-md md:mr-4">
          <h2 className="text-2xl font-bold mb-5 text-black">
            Cambia la información de tu cuenta
          </h2>
          <div>
            <label
              htmlFor="fullname"
              className="block font-medium text-gray-700"
            >
              Nombre completo
            </label>
            <input
              type="text"
              name="fullname"
              id="fullname"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-orange-600 focus:ring focus:ring-orange-600 focus:ring-opacity-50"
              value={fullname}
              onChange={handleChange}
            />
          </div>
          <div>
            <label
              htmlFor="address"
              className="block font-medium text-gray-700"
            >
              Dirección
            </label>
            <input
              type="text"
              name="address"
              id="address"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-orange-600 focus:ring focus:ring-orange-600 focus:ring-opacity-50"
              value={address}
              onChange={handleChangeAddress}
            />
          </div>
          <div>
            <label htmlFor="job" className="block font-medium text-gray-700">
              Trabajo
            </label>
            <input
              type="text"
              name="job"
              id="job"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-orange-600 focus:ring focus:ring-orange-600 focus:ring-opacity-50"
              value={job}
              onChange={handleChangeJob}
            />
          </div>
          <div>
            <label
              htmlFor="studies"
              className="block font-medium text-gray-700"
            >
              Estudios
            </label>
            <input
              type="text"
              name="studies"
              id="studies"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-orange-600 focus:ring focus:ring-orange-600 focus:ring-opacity-50"
              value={studies}
              onChange={handleChangeStudies}
            />
          </div>
          <div>
            <label
              htmlFor="description"
              className="block font-medium text-gray-700"
            >
              Descripción
            </label>
            <textarea
              name="description"
              id="description"
              rows="5"
              className="mt-1 block w-full rounded-md border-gray-300 shadow-sm focus:border-orange-600 focus:ring focus:ring-orange-600 focus:ring-opacity-50"
              value={description}
              onChange={handleChangeDescription}
            ></textarea>
          </div>
          <div className="mt-4">
            <button
              className="bg-orange-600 hover:bg-orange-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
              onClick={handleClick}
            >
              Guardar cambios
            </button>
          </div>
        </div>
        <div className="flex flex-col space-y-8 ml-8">
          <div className="bg-white p-6 rounded-md shadow-md">
            <div className="mb-6 justify-center">
              <Toggle />
            </div>

            <h2 className="text-2xl font-bold mb-4">Cambia el avatar</h2>
            <AvatarUpload />
            <h2 className="text-2xl font-bold mb-4">
              Cambia el fondo de tu perfil
            </h2>
            <UploadFile />
          </div>
        </div>
      </div>
      <hr className="border-t-2 border-gray-300 my-8 mx-4" />
      <div className="mt-6">
        <ChangePasswordForm />
      </div>
    </>
  );
}
