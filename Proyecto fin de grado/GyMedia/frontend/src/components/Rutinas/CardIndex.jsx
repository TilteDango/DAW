import React from "react";
import RutinasCard from "./RutinasCard";
import { useState, useEffect, useContext } from "react";
import { AuthContext } from "../../Context/AuthContext";
import Tab from "../Recetas/Tab";
import AddPost from "../Buttons/AddPost";
import AddRutina from "../Buttons/AddRutina";

export default function CardIndex() {
  const [exercices, setExercices] = useState([]);
  const [exercicesByToken, setExercicesByToken] = useState([]);
  const { token, setToken } = useContext(AuthContext);
  const [active, setActive] = useState(true);

  const changeActive = async () => {
    setActive(!active);
    const postByToken = await getAllExercicesByToken();
  };

  async function getAllExercicesByToken() {
    const exercicies = await fetch(
      `http://127.0.0.1:6001/api/postExercices/byToken`,
      {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          token: token,
        }),
      }
    ).then((res) => {
      return res.json();
    });
    setExercicesByToken(exercicies);
  }

  async function getExercices() {
    const exercicies = await fetch(`http://127.0.0.1:6001/api/postExercices`, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    }).then((res) => {
      return res.json();
    });
    return exercicies;
  }

  useEffect(() => {
    async function getData() {
      const exercicies = await getExercices();
      setExercices(exercicies);
    }

    getData();
  }, []);

  return (
    <>
      {token ? (
        <>
          {active ? (
            <>
              <div className="flex w-2/4 m-auto justify-evenly">
                <Tab active={true}>Rutinas recomendadas</Tab>
                <Tab active={false} changeActive={changeActive}>
                  Tus Rutinas
                </Tab>
              </div>
              <div className="mt-4 mx-4">
                <div className="grid grid-cols-4 gap-4 justify-items-center">
                  {exercices.map((exercice, index) => (
                    <div key={index} className="h-full">
                      <RutinasCard exercice={exercice} key={index} />
                    </div>
                  ))}
                </div>
              </div>
            </>
          ) : (
            <>
              <div className="flex w-2/4 m-auto justify-evenly">
                <Tab active={false} changeActive={changeActive}>
                  Rutinas recomendadas
                </Tab>
                <Tab active={true}>Tus Rutinas</Tab>
              </div>
              <AddRutina />
              <div className="mt-4 mx-4">
                <div className="grid grid-cols-4 gap-4 justify-items-center">
                  {exercicesByToken.map((exercice, index) => (
                    <div key={index} className="h-full">
                      <RutinasCard exercice={exercice} key={index} />
                    </div>
                  ))}
                </div>
              </div>
            </>
          )}
        </>
      ) : (
        <>
          <div className="mt-4 mx-4">
            <div className="grid grid-cols-4 gap-4 justify-items-center">
              {exercices.map((exercice, index) => (
                <div key={index} className="h-full">
                  <RutinasCard exercice={exercice} key={index} />
                </div>
              ))}
            </div>
          </div>
        </>
      )}
    </>
  );
}
