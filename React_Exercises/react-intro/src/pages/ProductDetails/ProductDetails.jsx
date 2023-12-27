import axios from 'axios';
import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router-dom';

export default function ProductDetail() {

  const productURL = "https://dummyjson.com/products";

  const params = useParams(); // location
  const [product, setProduct] = useState();
  useEffect(() => {
    if (params.id) {
      let response =axios.get(productURL + '/' + params.id).then(response => {
        setProduct(response.data);
        console.log(params.id)
      });
    }
  }, []);
  return (
    <div>
      <div className="card" >
        <img src={product.thumbnail} className="card-img-top" alt="..." />
        <div className="card-body">
          <h5 className="card-title">{product.title}</h5>
          <p className="card-text">{product.description}</p>
        </div>
        <ul className="list-group list-group-flush">
          <li className="list-group-item">{product.price}</li>
          <li className="list-group-item">{product.rating}</li>
          <li className="list-group-item">{product.stock}</li>
        </ul>
        <div className="card-body">
          <a href="#" className="card-link">Card link</a>
          <a href="#" className="card-link">Another link</a>
        </div>
      </div>
    </div>
  )
}