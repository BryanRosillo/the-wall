import { useState } from 'react'
import './App.css'
import WallPage from '../features/wall/WallPage';

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <WallPage />
    </>
  )
}

export default App
