import axios from 'axios'
import apiEndpoint from "../../apiEndpoint";

export const makeOrder = (goodsIds, name, phone, details) => {
    var request = {
        customerName: name,
        phoneNumber: phone,
        orderDetails: details,
        orderProducts: goodsIds
    }
    axios.post(`${apiEndpoint}/shop/makeorder`, request).then(({data}) => {
    }).catch(error => { return error});
}