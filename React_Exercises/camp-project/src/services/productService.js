import axios from "axios";
export default class ProductService{
    getProducts(){
        return axios.get("http://localhost:2372/api/Products") .then(response => {
            console.log(response.data);
          })
    }
}