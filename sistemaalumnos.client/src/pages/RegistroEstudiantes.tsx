import MainLayout from "../layouts/MainLayout";
function RegistroEstudiantes() {
  return (
  <div>
    <MainLayout text="Registro de Estudiantes">
      {/* A partir de aqui pueden empezar a crear el diseño */}
      <div className="p-4">
        <h2 className="text-2xl font-semibold mb-4">Registro de Estudiantes</h2>
        <p className="mb-2">Aquí podrás registrar nuevos estudiantes.</p>
      </div>
    </MainLayout>
  </div>
)
}

export default RegistroEstudiantes;
