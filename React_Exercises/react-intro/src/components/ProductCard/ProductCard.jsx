import React from "react";
import {Link} from "react-router-dom";
import axios from "axios";

export default function ProductCard(props) {
	const productDelete = () => {
		alert("Silmek istediğinizden emin misiniz?");
		axios.delete("https://dummyjson.com/products/" + props.product.id);
		//window.location.reload();
		alert("Silindi");
	  }
	return (
		<div className="card">
			<img src={props.product.thumbnail} className="card-img-top" alt="..." />
			<div className="card-body">
				<h5 className="card-title">{props.product.title}</h5>
				<p className="card-text">{props.product.description}</p>
				<Link
					to={"/product-detail?id=" + props.product.id}
					className="btn btn-primary"
				>
					Details
				</Link>
				<button className="btn btn-danger" onClick={productDelete}>Sil</button>
			</div>
		</div>
	);
}