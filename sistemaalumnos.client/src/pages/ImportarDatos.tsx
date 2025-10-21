import MainLayout from "../layouts/MainLayout";
function importarDatos() {
  return (
    <div>
      <MainLayout text="Importar Datos">
        {/* A partir de aqui pueden empezar a crear el diseño */}
        <div className="p-4">
          <h2 className="text-2xl font-semibold mb-4">Importar Datos</h2>
          <p className="mb-2">Aquí podrás importar los datos de los estudiantes.</p>
        </div>
      </MainLayout>
    </div>

  )
}
export default importarDatos;
