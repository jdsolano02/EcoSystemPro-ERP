import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
        <a href="https://vite.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
          <h1>Vite + React</h1>
          <div className="flex min-h-screen flex-col items-center justify-center bg-slate-900 text-white">
              <h1 className="mb-4 text-5xl font-bold text-blue-500">
                  �Hola Mundo!
              </h1>
              <p className="text-xl text-gray-300">
                  Tailwind CSS v4 estoy corriendo en EcoSystem Pro
              </p>
              <button className="mt-6 rounded-lg bg-green-600 px-6 py-3 font-semibold transition-colors hover:bg-green-700">
                  Click me
              </button>
          </div>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App