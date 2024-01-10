import axios from "axios";

export default class ProductService{
    getProducts(){
        return axios.get("https://dummyjson.com/products");
    }

    getByProductId(productId){
        return axios.get("https://dummyjson.com/products/"+ productId)
    }
}