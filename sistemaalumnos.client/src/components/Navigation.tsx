import React from "react";
import ButtonLink from "./ButtonLink";
const Navigation: React.FC = () => {
  return (
    <nav className=" w-1/6 bg-gray-800 text-white p-4">
      <ul className="space-y-4">
        <ButtonLink to="/" text="Inicio" />
        <ButtonLink to="/Registro" text="Registro de Estudiantes" />
        <ButtonLink to="/Factores" text="Factores de Riesgo" />
        <ButtonLink to="/Pareto" text="Pareto" />
        <ButtonLink to="/Ishikawa" text="Ishikawa" />
        <ButtonLink to="/Histograma" text="Histograma" />
        <ButtonLink to="/Dispersion" text="Dispersion" />
        <ButtonLink to="/Importar" text="Importar Datos" />
        <ButtonLink to="/Exportar" text="Exportar Datos" />
      </ul>
    </nav>
  );
};

export default Navigation;
