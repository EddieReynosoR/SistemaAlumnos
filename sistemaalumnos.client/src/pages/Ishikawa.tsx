import MainLayout from '../layouts/MainLayout';
function Ishikawa() {
  return (
    <div>
      <MainLayout text="Diagrama de Ishikawa">
        {/* A partir de aqui pueden empezar a crear el diseño */}
        <div className="p-4">
          <h2 className="text-2xl font-semibold mb-4">Diagrama de Ishikawa</h2>
          <p className="mb-2">Aquí podrás visualizar el diagrama de Ishikawa de los estudiantes.</p>
        </div>
      </MainLayout>
    </div>
  );
}

export default Ishikawa;
