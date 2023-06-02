import { DietList } from "./DietList";
import Tab from "./Tab";
import { useState, useContext } from "react";
import { AuthContext } from "../../Context/AuthContext";
import NewRecipe from "../Buttons/NewRecipe";

function Recetas() {
  const [active, setActive] = useState(true);
  const { token, setToken } = useContext(AuthContext);

  const changeActive = () => {
    setActive(!active);
  };

  return (
    <>
        {token ? (
          <>
            {active ? (
              <>
                <div className="flex w-2/4 m-auto justify-evenly">
                  <Tab active={true}>Recetas Recomendadas</Tab>
                  <Tab active={false} changeActive={changeActive}>
                    Tus Recetas
                  </Tab>
                </div>
                <DietList active={false} />
              </>
            ) : (
              <>
                <div className="flex w-2/4 m-auto justify-evenly">
                  <Tab active={false} changeActive={changeActive}>
                    Recetas Recomendadas
                  </Tab>
                  <Tab active={true}>Tus Recetas</Tab>
                </div>
                <div className="flex">
                  <div className="flex justify-end w-3/4 ">
                    <DietList active={true} />
                  </div>
                  <div className="w-1/4">
                    <NewRecipe />
                  </div>
                </div>
              </>
            )}
          </>
        ) : (
          <>
            <DietList />
          </>
        )}
    </>
  );
}

export default Recetas;
