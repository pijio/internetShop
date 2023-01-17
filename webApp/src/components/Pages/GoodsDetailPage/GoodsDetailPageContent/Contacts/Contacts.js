import './Contacts.css'
const Contacts = ({sortRef,contact})=>{
    return (
            <div  ref={sortRef}  className={contact===false?'contact__block':'contact__block active__contact'}>
                <h2 className={'contact__us'}>Связаться с нами</h2>
                <div className={'contact__infoblock'}>
                    <img src="https://img.icons8.com/ios-filled/50/4a90e2/point-of-interest.png"/>
                    <h4> <span className={'span__bold'}>Адрес:</span>  г. Бишкек - пр. Шабдана Батыра 6А (Пересекает пр. Чуй)</h4>
                </div>
                <div className={'contact__infoblock'}>
                    <img src="https://img.icons8.com/ios-filled/50/4a90e2/cell-phone.png"/>
                    <h4> <span className={'span__bold'}>Контактные телефоны:</span><br/> 88005553535 <br/> +996552553535 </h4>
                </div>
                <div className={'contact__infoblock'}>
                    <img src="https://img.icons8.com/ios-filled/50/4a90e2/cloud-mail.png"/>
                    <h4> <span className={'span__bold'}>Почта:</span> <br/> m2495aw@yandex.ru <br/> bushev@krsu.edu.kg </h4>
                </div>
                <div className={'contact__infoblock'}>
                    <img src="https://img.icons8.com/ios-filled/50/4a90e2/about.png"/>
                    <h4> <span className={'span__bold'}>О нас:</span> <a href="#">больше информации по ссылке</a></h4>
                </div>
            </div>
    )
}
export default Contacts
