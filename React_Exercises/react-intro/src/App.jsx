import {BrowserRouter, Routes, Route} from "react-router-dom";
import "./App.css";
import Homepage from "./pages/Homepage/Homepage";
import About from "./pages/About/About";
import Navbar from "./components/Navbar/Navbar";
import ProductDetails from './pages/ProductDetails/ProductDetails';


function App() {
	return (
		<>
			<Navbar />
			<BrowserRouter>
				<Routes>
					<Route path="/" element={<Homepage />}></Route>
					<Route path='/product-detail/:id' element={<ProductDetails />}></Route>
					<Route path="/about" element={<About />}></Route>
					<Route path="*" element={<p>Not Found</p>}></Route>
				</Routes>
			</BrowserRouter>
		</>
	);
}
export default App;
/* 
Ürün detay sayfası
Ürün ekleme sayfası
Ürün silme fonksiyonu
*/