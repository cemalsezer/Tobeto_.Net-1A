import './App.css';
import React, { useState } from 'react';
import { Input } from 'semantic-ui-react'

function App() {
    const [todos, setTodos] = useState([]);
    const [newTodo, setNewTodo] = useState('');
  
    const handleInputChange = (x) => {
      setNewTodo(x.target.value);
    };
  
    const handleAddTodo = () => {
      if (newTodo.trim() !== '') {
        setTodos([...todos, newTodo]);
        setNewTodo('');
      }
    };

  return (
    <div className='App'>
    <h1>Todo App</h1>
      <div>
        <Input
          type="text"
          placeholder="Yapılacakları Ekleyin"
          value={newTodo}
          onChange={handleInputChange}
        />
        <button class="ui button" onClick={handleAddTodo}>Ekle</button>

      </div>
      <ul>
        {todos.map((todo, index) => (
          <li key={index}>{todo}</li>
        ))}
      </ul>
  </div>
  );
  
}

export default App;
