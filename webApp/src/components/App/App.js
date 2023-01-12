import './App.css';
import {React} from 'react'
import {BrowserRouter, Redirect, Route, Switch} from "react-router-dom";
import Cart from "../Pages/CartPages/Cart";
import Main from "../Pages/MainPage";
import GoodsDetailPage from "../Pages/GoodsDetailPage";
import ShopForm from "../Pages/ShopForm/ShopForm";
import {useDispatch, useSelector} from "react-redux";
import CartEmpty from "../Pages/CartPages/CartEmpty";
import NotFoundPage from "../Pages/ErrorPages/NotFoundPage";
import AuthForm from "../Pages/AuthPages/AuthForm";
import useAuth from "../../hooks/useAuth/useAuth";
import {setAuthed} from "../../redux/actions/auth";
import UnauthorizedPage from "../Pages/ErrorPages/UnauthorizedPage";
import Logout from "../Pages/AuthPages/Logout";
function App() {
    const {totalCount} = useSelector(({cart}) => cart);
    const {isAuth} = useAuth()
    const dispatch = useDispatch()
    dispatch(setAuthed(isAuth))
    return (
        <BrowserRouter>
            <Switch>
                <Route exact path={'/'} component={Main}/>
                <Route exact path={'/cart'} component={totalCount ? Cart : CartEmpty}/>
                <Route exact path={'/details'} component={GoodsDetailPage}/>
                <Route exact path={'/notfound'} component={NotFoundPage}/>
                <Route exact path={'/unauth'} component={UnauthorizedPage}/>
                <Route exact path={'/auth'} component={AuthForm}/>
                <Route exact path={'/logout'} component={Logout}/>
                <Redirect to={'/notfound'}/>
            </Switch>
        </BrowserRouter>
    );
}

export default App;
