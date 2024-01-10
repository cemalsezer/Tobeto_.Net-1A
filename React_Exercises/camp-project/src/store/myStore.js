import { configureStore } from "@reduxjs/toolkit";
import rootReducer from "./rootReducer";

export function store() {
  return configureStore({reducer:rootReducer})
};