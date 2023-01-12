import {combineReducers} from "redux";
import goods from "./goods";
import filters from "./filters";
import detail from "./details";
import cart from "./cart";
import auth from "./auth";
const rootReducer = combineReducers({
    cart ,
    filters,
    goods,
    detail,
    auth
})
export default rootReducer