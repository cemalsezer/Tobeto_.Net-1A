import { configureStore } from "@reduxjs/toolkit";
// import { devToolsEnhancer } from "@redux-devtools/extension";
import rootReducer from "./rootReducer";

export function store() {
  return configureStore({reducer:rootReducer})
};