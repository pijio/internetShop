import './App.css';
import {React} from 'react'
import {BrowserRouter as Router, Route} from "react-router-dom";
import Cart from "../Pages/CartPages/Cart";
import Main from "../Pages/MainPage";
import GoodsDetailPage from "../Pages/GoodsDetailPage";
import ShopForm from "../Pages/ShopForm/ShopForm";
import {useSelector} from "react-redux";
import CartEmpty from "../Pages/CartPages/CartEmpty";


function App() {
    const {totalCount} = useSelector(({cart}) => cart);
    return (
        <Router>
            <Route exact path={'/'} component={Main}/>
            <Route exact path={'/cart'} component={totalCount ? Cart : CartEmpty}/>
            <Route exact path={'/details'} component={GoodsDetailPage}/>
        </Router>
    );
}

export default App;
