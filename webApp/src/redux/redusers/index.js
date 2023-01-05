import {combineReducers} from "redux";
import goods from "./goods";
import filters from "./filters";
import detail from "./details";
import cart from "./cart";
const rootReducer = combineReducers({
    cart ,
    filters,
    goods,
    detail,
})
export default rootReducer