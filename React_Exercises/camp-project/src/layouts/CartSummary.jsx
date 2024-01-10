import React, { useEffect, useState } from "react";
import { Dropdown,Button, DropdownMenu, Label,DropdownItem } from 'semantic-ui-react'
import { NavLink } from 'react-router-dom'
import { useDispatch, useSelector } from "react-redux";
import { addToCart, removeFromCart } from "../store/actions/cartActions";

export default function CartSummary() {
  const { cartItems } = useSelector((state) => state.cart);
  const [isMenuOpen,setIsMenuOpen]=useState(false);
  const dispatch=useDispatch();
  const handleDecrease=(product)=>{
    dispatch(removeFromCart(product));
  }
  const handleIncrease=(product)=>{
    dispatch(addToCart(product));
  }
  const onDropdownClick=()=>{
    setIsMenuOpen(!isMenuOpen);
  } 
  return (
    <div>
          <Dropdown item text="Sepetiniz" >
        <DropdownMenu open={isMenuOpen} onClick={()=>onDropdownClick()}>
          {
          cartItems.map((item,index) => 
            <DropdownItem key={index}>
              {item.product.title+" : "}
              <Label>{item.quantity}</Label>
              <Button onClick={()=>handleIncrease(item.product)}>+</Button>
              <Button onClick={()=>handleDecrease(item.product)}>-</Button>
              </DropdownItem>
          )
          }

          <Dropdown.Divider/>
          <DropdownItem as={NavLink} to="/cart">
            Sepete git
          </DropdownItem>
        </DropdownMenu>
      </Dropdown>
    </div>
  )
}
