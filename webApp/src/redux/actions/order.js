import axios from 'axios'

export const makeOrder = (goodsIds, name, phone, details) => {
    var baseUrl = "https://localhost:5003"
    var request = {
        customerName: name,
        phoneNumber: phone,
        orderDetails: details,
        orderProducts: goodsIds
    }
    return (
        axios.post(`${baseUrl}/shop/makeorder`, request).then(({data}) => {
        }).catch(error => console.log('Интернет включи')));
}