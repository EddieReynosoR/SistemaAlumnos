import './App.css'
import { Routes, Route } from 'react-router-dom'

import Home from './pages/Home'
import RegistroEstudiantes from './pages/registroEstudiantes'
import FactoresRiesgo from './pages/FactoresRiesgo'
import Pareto from './pages/Pareto'
import Ishikawa from './pages/Ishikawa'
import Histograma from './pages/Histogramas'
import Dispersion from './pages/Dispersion'
import ImportarDatos from './pages/ImportarDatos'
import ExportarDatos from './pages/ExportarDatos'







function App() {

  return (
    <>
      <Routes>
        <Route path="/*" element={<Home />} />
        <Route path="/Registro" element={<RegistroEstudiantes />} />
        <Route path="/Factores" element={<FactoresRiesgo />} />
        <Route path="/Pareto" element={<Pareto />} />
        <Route path="/Ishikawa" element={<Ishikawa />} />
        <Route path="/Histograma" element={<Histograma />} />
        <Route path="/Dispersion" element={<Dispersion />} />
        <Route path="/Importar" element={<ImportarDatos />} />
        <Route path="/Exportar" element={<ExportarDatos />} />
      </Routes>

      </>
  )
}

export default App
