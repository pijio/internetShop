import './ShopForm.css'
import {Link} from "react-router-dom";
import React from "react";
import {useSelector} from "react-redux";

const ShopForm = () => {

    const {totalPrice, totalCount, items} = useSelector(({cart}) => ({
        totalPrice: cart.totalPrice,
        totalCount: cart.totalCount,
        items: cart.items
    }));
    const groupedFirstItems = Object.keys(items).map(key => {
        return items[key][0]
    });
    const goodsItems = groupedFirstItems.map((item) => item.name)

    const groupedAllItems = Object.keys(items).map(key => {
        return items[key];
    });

    return (
        <form target={'_blank'}
              action={''}
              className="card">
            <Link to={'/'}>
                <img className={'toHome__Button1'} src="https://cdn-icons-png.flaticon.com/512/6298/6298551.png"
                     alt=""/>
            </Link>
            <h2 className={'h2__order'}>Оформить Заказ</h2>
            <div className="row">
                <div className="col">
                    <div className="form-group">
                        <label className="label-form">Ваше Имя</label>
                        <input required={true} className="input" type="text"/>
                    </div>
                </div>

                <div className="col selected__gods">
                    <div className="form-group">
                        <label className="label-form">Выбранные товары ({totalCount})</label>
                        <textarea readOnly type="text"
                                  value={goodsItems}/>
                    </div>
                </div>

                <div className="col">
                    <div className="form-group">
                        <label className="label-form">Телефон</label>
                        <input required={true} className="input" type="tel"/>
                    </div>
                </div>

                <div className="col">
                    <div className="form-group">
                        <label className="label-form">Общая сумма заказа</label>
                        <input name="entry.635165254" readOnly value={`${totalPrice} сом`}
                               type="text"/>
                    </div>
                </div>

                <div className="col">
                    <div className="form-group">
                        <label className="label-form">Адрес доставки и комментарий к заказу</label>
                        <textarea autoComplete={'Введите Ваш адрес'} required={true} className="input"
                                  ></textarea>
                    </div>
                </div>

                <div className="col">
                    <input type="submit" value="Отправить"/>
                </div>
            </div>
        </form>
    )
}
export default ShopForm
