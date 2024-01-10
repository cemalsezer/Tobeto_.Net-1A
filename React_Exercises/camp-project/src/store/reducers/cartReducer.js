import { ADD_TO_CART, REMOVE_FROM_CART } from "../actions/cartActions";
import { cartItems } from "../initialValues/cartItems";

const initialState = {
  cartItems: cartItems,
};

export default function cartReducer(state = initialState, { type, payload }) {
  let newState = JSON.parse(JSON.stringify(state));
  let product = newState.cartItems.find((p) => p.product.id === payload.id);
  switch (type) {
    case ADD_TO_CART:
      if (product) {
        product.quantity++;
      } else {
        newState.cartItems.push({ quantity: 1, product: payload });        
      }
      return newState;
    case REMOVE_FROM_CART:
        if (product.quantity>1) {
            product.quantity--;
        }
        else{
            newState.cartItems= newState.cartItems.filter((p) => p.product.id !== payload.id)
        }
      return newState;
    default:
      return state;
  }
}