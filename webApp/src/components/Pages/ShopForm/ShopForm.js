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
              action={'https://docs.google.com/forms/d/e/1FAIpQLScoQmMotRKXb2NSf6F3a0ON36UJyl4MSG5QdoFdMnSpDWh_Tg/formResponse'}
              className="card">
            <Link to={'/'}>
                <img className={'toHome__Button1'} src="https://cdn-icons-png.flaticon.com/512/6298/6298551.png"
                     alt=""/>
            </Link>
            <h2 className={'h2__order'}>Оформить Заказ</h2>
            <div className="row">
                <div className="col">
                    <div className="form-group">
                        <label>Ваше Имя</label>
                        <input aria-describedby="i4" name="entry.410786545" required={true} type="text"/>
                    </div>
                </div>

                <div className="col">
                    <div className="form-group">
                        <label>Выбранные товары ({totalCount})</label>
                        <textarea aria-describedby="i12" name="entry.462709995" readOnly type="text"
                                  value={goodsItems}/>
                    </div>
                </div>

                <div className="col">
                    <div className="form-group">
                        <label>Телефон</label>
                        <input aria-describedby="i8" name="entry.1366590193" required={true} type="tel"/>
                    </div>
                </div>

                <div className="col">
                    <div className="form-group">
                        <label>Общая сумма заказа</label>
                        <input aria-describedby="i16" name="entry.635165254" readOnly value={`${totalPrice} сом`}
                               type="text"/>
                    </div>
                </div>

                <div className="col">
                    <div className="form-group">
                        <label>Адрес доставки и <br/>комментарий к заказу</label>
                        <textarea autoComplete={'Введите Ваш адрес'} required={true} name="entry.46350536"
                                  aria-describedby="i20"></textarea>
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
