import React from "react";

export default function ChangePasswordForm() {
  return (
    <div className="relative py-3 sm:w-96 mx-auto text-center">
      <span className="text-2xl font-bold text-gray-900">
        Cambia tu contraseña
      </span>
      <div className="mt-4 bg-white shadow-md rounded-lg text-left">
        <div className="h-2 bg-orange-600 rounded-t-md"></div>
        <div className="px-8 py-6">
          <label className="block font-semibold">Contraseña actual</label>
          <input
            type="text"
            placeholder="Contraseña actual"
            className="border border-gray-400 w-full h-5 px-3 py-5 mt-2 hover:outline-none focus:outline-none focus:ring-orange-600 focus:ring-1 rounded-md"
          />
          <label className="block mt-3 font-semibold">Nueva contraseña</label>
          <input
            type="password"
            placeholder="Nueva contraseña"
            className="border border-gray-400 w-full h-5 px-3 py-5 mt-2 hover:outline-none focus:outline-none focus:ring-orange-600 focus:ring-1 rounded-md"
          />
          <label className="block mt-3 font-semibold">
            Confirmar nueva contraseña
          </label>
          <input
            type="password"
            placeholder="Confirmar nueva contraseña"
            className="border border-gray-400 w-full h-5 px-3 py-5 mt-2 hover:outline-none focus:outline-none focus:ring-orange-600 focus:ring-1 rounded-md"
          />
          <div className="flex justify-between items-baseline">
            <button
              type="submit"
              className="mt-4 bg-orange-600 text-white py-2 px-6 rounded-md hover:bg-orange-700"
            >
              Cambiar contraseña
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}
