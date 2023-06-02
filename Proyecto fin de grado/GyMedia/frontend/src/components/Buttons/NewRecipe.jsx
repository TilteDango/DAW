import React from "react";
import { useState} from "react";
import FormAddRecipe from "../AddRecipe/FormAddRecipe";

export default function NewRecipe() {
  const [modalOn, setModalOn] = useState(false);

  const handleClose = () => {
    setModalOn(false);
  };

  const handleClick = () => {
    setModalOn(true);
  };

  
  return (
    <>
    <button className="bg-orange-500 hover:bg-orange-600 text-white font-bold py-2 px-4 rounded" onClick={handleClick}>
      + Receta
    </button>
    {modalOn && <FormAddRecipe modalOn={modalOn} onClose={handleClose} />}
    </>
  );
}
