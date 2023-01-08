insert into "ProductsCharacteristics"
("Processor", "Ram", "MatrixType", "RelationSide", "Dpi", "Format", "PrinterRam", "PrinterType", "ScreenSize", "Os", "DiscVolAndType") 
values
('Intel i7', '16GB', '', null, '', '', '', null, '15.6''', 'DOS', '1TB SSD'),
('Intel i7', '16GB', '', null, '', '', '', null, '15.6''', 'Win 10', '512GB SSD'),
('Intel i7', '16GB', '', null, '', '', '', null, '15.6''', 'Windows 11', '512GB SSD'),
('Ryzen 7', '16GB', '', null, '', '', '', null, '16.1''', 'Windows 11', '1TB SSD'),
('Core i7-11800H', '32GB', '', null, '', '', '', null, '16.1''', 'Win10Pro', '1TB SSD'),
('Core i7-1165G7', '32GB', '', null, '', '', '', null, '13.1''', 'Win10Pro', '2TB SSD'),
('Core i7 10510U', '8GB', '', null, '', '', '', null, '15.6''', 'Win10Pro', 'SSD 265'),
('Intel Core i5', '8GB', '', null, '', '', '', null, '13.5''', 'Win10Pro', 'SSD 512Gb'),
('Core i7-1165G7', '8GB', '', null, '', '', '', null, '15.6''', 'Win10Pro', 'SSD 512Gb'),
(null, null, '20 стр/мин', null, '600x600dpi', 'A3', '448 MB', null, null, null, null),
(null, null, '38 стр/мин', null, '600x600dpi', 'A4', '2 GB', null, null, null, null),
(null, null, '56 стр/мин', null, '1200x1200dpi', 'A4', '1 GB', null, null, null, null),
(null, null, '40 стр/мин', null, '1200x1200dpi', 'A3', '7 GB', null, null, null, null),
(null, null, '20 стр/мин', null, '600x1200dpi', 'A4', '500MB', null, null, null, null),
(null, null, '20 стр/мин', null, '600x600dpi', 'A4', '500MB', null, null, null, null),
('Intel i-9', '64 GB', null, null, null, null, null, null, null, 'Win 11', '10TB'),
('Intel i-5', '8 GB', null, null, null, null, null, null, null, 'Win 10', '512GB'),
('Intel i-3', '8 GB', null, null, null, null, null, null, null, 'Win 10', '256GB'),
('Intel i-9', '64 GB', null, null, null, null, null, null, null, 'Win 11', '10TB'),
(null, null, '22000/мес', null, null, null, null, null, null, null, null),
(null, null, '22000/мес', null, null, null, null, null, null, null, null),
(null, null, '29000/мес', null, null, null, null, null, null, null, null),
(null, '(16:9)', 'IPS', null, '1920х1080 ', '27''', null, null, null, '75Hz', null),
(null, '(16:9)', 'IPS', null, '1920х1080 ', '24''', null, null, null, '75Hz', null),
(null, '(16:9)', 'IPS', null, '2560x1440 ', '27''', null, null, null, '240Hz', null),
(null, '(16:9)', 'IPS', null, '2560x1440 ', '32''', null, null, null, '240Hz', null)

insert into "ProductTypes"
("TypeName")
values
('Мониторы'),
('Принтеры'),
('МФУ'),
('ПК'),
('Картриджи'),
('Ноутбуки')

insert into "ProductAdditInfos"
("ImageUrl", "ImageUrl1", "ImageUrl2", "ImageUrl3", "VideoUrl")
values
('https://avatars.mds.yandex.net/get-mpic/4592225/img_id6657629359034239630.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4809583/img_id7347036862735248351.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4544006/img_id83840
29848832051067.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5191310/img_id7740413371672130953.jpeg/9hq', 'https://www.youtube.com/embed/MMk4x6fwjMc'),
('https://avatars.mds.yandex.net/get-mpic/4497593/img_id5684588489513161547.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4944925/img_id8029086303961429919.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4080967/img_id6014
782703280711369.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4409630/img_id6793443146931594424.jpeg/9hq', 'https://www.youtube.com/embed/TjscXOIpxSk'),
('https://avatars.mds.yandex.net/get-mpic/4397006/img_id6741380365012425822.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4262452/img_id4937853067112999626.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4497593/img_id9139
664672008180587.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/3925628/img_id1716707799223220456.jpeg/9hq', 'https://www.youtube.com/embed/kFVsSoO9dVw'),
('https://avatars.mds.yandex.net/get-mpic/5289292/img_id1160295558447144977.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/5209746/img_id7731466554637246858.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/5210335/img_id935563
362606384826.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/5146425/img_id6077389971241151999.png/9hq', 'https://www.youtube.com/embed/Nq9dXH95ssA'),
('https://avatars.mds.yandex.net/get-mpic/4220209/img_id389727445181632590.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4120567/img_id1413039304259736094.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4120567/img_id18247
05485359949140.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4220209/img_id3342881985229153969.jpeg/9hq', 'https://www.youtube.com/embed/Hz9GfxCAXgs'),
('https://avatars.mds.yandex.net/get-mpic/5229883/img_id6291886343634373689.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5238231/img_id3861015466507867195.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/5252277/img_id39861
96128900499082.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/5229883/img_id6291886343634373689.jpeg/9hq', 'https://www.youtube.com/embed/FYDDjcwfJSw'),
('https://avatars.mds.yandex.net/get-mpic/4449143/img_id635213691843706262.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4255269/img_id8739815037193636204.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4291905/img_id18355
50925032386386.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4497593/img_id1529535705852621290.png/9hq', 'https://www.youtube.com/embed/JHMZ273Srjo'),
('https://avatars.mds.yandex.net/get-mpic/4948493/img_id8444968467887426530.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/3611742/img_id6321792428437818520.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4497593/img_id8782
007271606727603.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4220209/img_id4164601570706673201.jpeg/9hq', 'https://www.youtube.com/embed/6d5xcH6FV3g'),
('https://avatars.mds.yandex.net/get-mpic/4497593/img_id5684588489513161547.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4944925/img_id8029086303961429919.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4080967/img_id6014
782703280711369.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4409630/img_id6793443146931594424.jpeg/9hq', 'https://www.youtube.com/embed/0TCratvjBZg'),
('https://avatars.mds.yandex.net/get-mpic/4393885/img_id5012674354450989117.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4355034/img_id787928428974464742.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4732637/img_id81578
42064341517870.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4120716/img_id3128572624882345619.jpeg/9hq', 'https://www.youtube.com/embed/a6catogT0lY'),
('https://avatars.mds.yandex.net/get-mpic/4304254/img_id4975994914453653631.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/1538707/img_id4327337995056967550/9hq', 'https://avatars.mds.yandex.net/get-mpic/1526692/img_id733632633
6357117861/9hq', 'https://avatars.mds.yandex.net/get-mpic/175985/img_id7114621646409357151/9hq', 'https://youtu.be/MMk4x6fwjMc'),
('https://avatars.mds.yandex.net/get-mpic/4949903/img_id3993862366319076161.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4949903/img_id3993862366319076161.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4949903/img_id3993
862366319076161.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4949903/img_id3993862366319076161.jpeg/9hq', 'https://www.youtube.com/embed/LIOKbWgwdjM'),
('https://avatars.mds.yandex.net/get-mpic/4334326/img_id6108120921675314035.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/1862611/img_id2702260262427752157.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/1521939/img_id664797
2141275947713.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4362876/img_id8918931554612468217.jpeg/9hq', 'https://www.youtube.com/embed/5oydOHjUBcw'),
('https://avatars.mds.yandex.net/get-mpic/4119784/img_id3483597254001637411.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4012265/img_id7338325202032057068.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/1865271/img_id519640
1178551218325.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/1750349/img_id1152269488707633213.png/9hq', 'https://www.youtube.com/embed/B5rfXSBVYUI'),
('https://avatars.mds.yandex.net/get-mpic/4032259/img_id7060757167369036569.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4334746/img_id4577115231259918319.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4547325/img_id2607
749383814080854.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4353087/img_id3612167304879717743.jpeg/9hq', 'https://www.youtube.com/embed/0rVRCV_XJ7Y'),
('https://avatars.mds.yandex.net/get-mpic/5347250/img_id3007829870051008331.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5228105/img_id246459176306261181.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5335973/img_id83573
2648055566960.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5332815/img_id210884830550393316.jpeg/9hq', 'https://www.youtube.com/embed/4ZC7OgsjhFk'),
('https://avatars.mds.yandex.net/get-mpic/4012265/img_id5394235452277523886.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4119784/img_id4203990585664078802.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4012265/img_id539423
5452277523886.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4255269/img_id2316310101308916986.jpeg/9hq', 'https://www.youtube.com/embed/kiIKODULbdo'),
('https://avatars.mds.yandex.net/get-mpic/4353087/img_id6436641098121825574.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4448948/img_id4898237453770039068.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4342845/img_id6084
426072640633351.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5286714/img_id5922654388251433294.jpeg/9hq', 'https://www.youtube.com/embed/bvrm9j_GEI4'),
('https://avatars.mds.yandex.net/get-mpic/3698270/img_id2778715362292449960.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4355034/img_id5504151618119597372.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4615588/img_id75301
4553003540935.png/9hq', 'https://avatars.mds.yandex.net/get-mpic/4012481/img_id3202509642075922586.png/9hq', 'https://www.youtube.com/embed/McdGxbaBzpg'),
('https://www.tfk.ru/upload/iblock/a05/kartridzh_hp_651a_goluboy_16000_stranits_ce341a.webp?1618195164', 'https://www.tfk.ru/upload/iblock/a05/kartridzh_hp_651a_goluboy_16000_stranits_ce341a.webp?1618195164', 'https://www.tfk.ru/upl
oad/iblock/a05/kartridzh_hp_651a_goluboy_16000_stranits_ce341a.webp?1618195164', 'https://www.tfk.ru/upload/iblock/a05/kartridzh_hp_651a_goluboy_16000_stranits_ce341a.webp?1618195164', 'https://www.youtube.com/embed/6YgdZUt5Ubs'),
('https://avatars.mds.yandex.net/get-mpic/4944925/img_id7793775956269438487.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4410238/img_id4719107982962866.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5239537/img_id2317219
771176261191.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5252557/img_id1423470210156125575.png/9hq', 'https://www.youtube.com/embed/yZOAdEqX0Oo'),
('https://diamondelectric.ru/images/1761/1760797/sovmestimost_1.jpg', 'https://diamondelectric.ru/images/1761/1760797/sovmestimost_1.jpg', 'https://diamondelectric.ru/images/1761/1760797/sovmestimost_1.jpg', 'https://diamondelectric
.ru/images/1761/1760797/sovmestimost_1.jpg', 'https://www.youtube.com/embed/Z3FeY32kjyU'),
('https://avatars.mds.yandex.net/get-mpic/4304254/img_id5072366206001866733.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4408567/img_id2304830853181425096.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4721581/img_id5850
337983102004889.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4732637/img_id9123766077825442237.jpeg/9hq', 'https://www.youtube.com/embed/xXHYvAXwG7A'),
('https://avatars.mds.yandex.net/get-mpic/4372959/img_id8353362358445998974.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4080967/img_id9042253478571437200.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4721581/img_id5850
337983102004889.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4343092/img_id2633928952261367886.jpeg/9hq', 'https://www.youtube.com/embed/tNQZnIYI2jY'),
('https://avatars.mds.yandex.net/get-mpic/4490717/img_id344070484797028975.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4343038/img_id3001455480060601732.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5146425/img_id30165
25001831034327.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4464754/img_id7429983630992179725.jpeg/9hq', 'https://www.youtube.com/embed/NfEbO8SUrhQ'),
('https://avatars.mds.yandex.net/get-mpic/5332261/img_id7802077210870166475.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5204767/img_id6211408925779728326.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/4356316/img_id8373
467803057286599.jpeg/9hq', 'https://avatars.mds.yandex.net/get-mpic/5418200/img_id1740090915977543191.jpeg/9hq', 'https://www.youtube.com/embed/m2OsRghqGFc')

insert into "Products"
("InStock", "ProductTypeID", "Name", "Rate", "Title", "CharactId", "Price", "CharacteristicsCharactId", "InfoId", "AdditInfoInfoId", "CategoryId")
values
(1,6,Notebook HP Pavilion 15,5,"Не нужно ничем жертвовать - этот тонкий и мощный игровой ноутбук HP Pavilion безупречен во всем. Высококачественная графика и впечатляющая вычислительная мощность позволяют играть и выполнять
 несколько задач одновременно, а улучшенная система охлаждения обеспечит высокую производительность и стабильную работу. Полностью погрузись в игру благодаря экрану с узкими рамками и мощному звучанию. Идеальный баланс между работой
 и игрой.",1,85000,1,1,1,1),
(2,6,Ноутбук HP ProBook 650 G8,3,"Современный дизайн для офиса.
Современный дизайн HP ProBook 650 разработан специально для корпоративной среды. Этот ноутбук не только стильно выглядит, но и обеспечивает производительность, надежность, безопасность и управляемость, соответствующую требованиям са
мых разных пользователей и бюджетов.",2,122600,2,2,2,1),
(3,6,Ноутбук HP ProBook 450 G7,3,"Мощь бизнес-класса по доступной цене
Этот полнофункциональный, тонкий, легкий и надежный HP ProBook 450 предоставляет всю необходимые возможности для любого бизнеса по доступной цене. Автоматические функции безопасности, высочайшая производительность и длительное время
 работы от аккумулятора помогают поддерживать максимальную эффективность вашего бизнеса.",3,156864,3,3,3,1),
(4,6,HP Victus 16-e0073ur,4,"Ноутбук Victus от HP с диагональю 16,1 дюйма, оснащенный процессором AMD, обладает всеми необходимыми функциями как для игр, так и для решения повседневных задач. Расширь свои возможности с пом
ощью универсальной игровой клавиатуры и наслаждайся качественным изображением на экране с высокой частотой обновления. Эффективная система охлаждения не допустит перегрева даже во время самых жарких сражений. Игровой центр OMEN Gami
ng Hub дополнительно расширяет возможности оборудования и дарит незабываемые впечатления от игры.",4,136600,4,4,4,1),
(5,6,HP ZBook 15 Studio G8,5,"От клавиатуры до экрана - каждый аспект ZBook Studio предназначен для рабочих процессов и производительности. Визуализируйте в режиме реального времени, сотрудничайте удаленно и даже играйте из
 любого места. Со всей мощью, собранной в небольшом корпусе, эта рабочая станция подойдёт для решения ваших рабочих задач.",5,296600,5,5,5,1),
(6,6,HP Elite Dragonfly G2,2,"Это потрясающее устройство почти у вас в руках
Оцените элегантный дизайн и надежную защиту этого невероятно мобильного ноутбука HP Elite Dragonfly. Система обработки звука на основе технологий искусственного интеллекта, яркий экран и поддержка беспроводного подключения Wi-Fi 6 о
беспечивают исключительно комфортные условия для совместной работы",6,200300,6,6,6,1),
(7,6,HP EliteBook 850 G7,4,"Ноутбук, который никогда не подведет
Для совместной работы необходим мощный, безопасный и надежный ноутбук, с которым вы сможете всегда быть на связи и эффективно работать в любых условиях. Легкий и удобный HP EliteBook 850 G7 с привлекательным дизайном всегда можно вз
ять с собой, а его возможности позволят вам успешно справляться с любыми задачами.",7,125000,7,7,7,1),
(8,6,HP Spectre x360 ,3,"Невероятно реалистичное изображение
На экране с высоким разрешением все детали выглядят четче, цвета насыщеннее, а ваши видеозаписи становятся более реалистичными. Благодаря удобному соотношению сторон 3:21 у вас появляется больше пространства и удобный обзор информац
ии.",8,114300,8,8,8,1),
(9,6,HP ProBook 450 G8,3,"Мощь бизнес-класса по доступной цене
Этот полнофункциональный, тонкий, легкий и надежный HP ProBook 450 предоставляет всю необходимые возможности для любого бизнеса по доступной цене. Автоматические функции безопасности, высочайшая производительность и длительное время
 работы от аккумулятора помогают поддерживать максимальную эффективность вашего бизнеса.",9,114300,9,9,9,1),
(10,2,HP Color LaserJet CP5225dn,2,"Этот универсальный и недорогой настольный принтер A3 позволяет печатать деловую документацию любого формата - от почтовых открыток до крупноформатных документов. Тонер HP ColorSphere, высо
кая скорость печати и удобство эксплуатации обеспечивают великолепное качество отпечатков и непревзойденную надежность.",10,12811,10,10,10,1),
(11,2,HP Color LaserJet M555x,5,"Идеальный выбор для предприятий с 5-15 сотрудниками и объемами печати до 10 000 страниц в месяц, которым требуется высококачественная цветная печать, а также быстрое сканирование и копирован
ие.",11,8138,11,11,11,1),
(12,2,HP Color LaserJet M653dn,3,"Этот принтер HP Color LaserJet с технологией JetIntelligence сочетает в себе исключительную производительность, пониженное энергопотребление и надежную печать документов профессионального ка
чества, при этом защищая вашу сеть с помощью встроенных средств обеспечения безопасности HP.",12,9490,12,12,12,1),
(13,3,HP Color LaserJet M776zs,4,"Эти усовершенствованные МФУ, оснащенные технологией JetIntelligence, обеспечивают великолепные цветные отпечатки. Экономьте время и упростите рабочие процессы благодаря самым безопасным уст
ройствам печати HP и широкому спектру функций подачи и укладки бумаги.
Принтер с поддержкой динамической безопасности. Предназначен для использования только с картриджами, оснащенными оригинальной микросхемой HP. Картриджи с микросхемами других производителей могут не работать, а работающие в настоящее
 время могут не работать в будущем.",13,564900,13,13,13,1),
(14,2,HP Color LaserJet M183fw,5,"Работайте там, где удобно
Удобная печать и сканирование с вашего мобильного устройства с помощью приложения HP Smart - лучшей в своем классе мобильной программы для печати.
Настраивайте ярлыки для повторяющихся задач. Сканирование в облако, электронную почту и другие функции - одним касанием.
Организуйте печать документов на 50% быстрее с помощью функции Smart Tasks.",14,30000,14,14,14,1),
(15,3,HP Color LaserJet M227sdn,3,"МФУ HP LaserJet Pro с картриджами JetIntelligence обеспечат более высокий уровень производительности и защиты. Задайте новые стандарты скорости для вашего бизнеса. Выполняйте быструю двусто
роннюю печать, сканирование, копирование и пересылку документов по факсу с простым управлением для повышения эффективности.",15,21000,15,15,15,1),
(16,4,HP Omen GT13-1001ur,3,Надежный ПК OMEN 30L с быстрым процессором Intel и мощной видеокартой NVIDIAR отличается стильным дизайном и позволит тебе играть на высшем уровне.,16,350000,16,16,16,1),
(17,4,HP ProDesk 400 G7 SFF,2,Компактный и надежный HP ProDesk 400 оснащен функциями безопасности. Его производительность можно масштабировать вместе с вашим бизнесом.,17,67000,17,17,17,1),
(18,4,HP ProDesk 400 G7 MT,1,"Надежность и готовность к расширению возможностей по мере развития бизнеса
Стильный и надежный ПК HP ProDesk 400 в корпусе Microtower специально разработан для современных офисов. Это мощный компьютер с эффективными функциями обеспечения безопасности, возможности которого можно расширять по мере развития в
ашего бизнеса.",18,72700,18,18,18,1),
(19,4,HP Z VR BackPack G2,5,"Раскройте потенциал VR с рабочей станцией, которая всегда под рукой. Передовые возможности и невероятная мощность в компактном переносимом устройстве.",19,172700,19,19,19,1),
(20,5,Картридж HP 656X,4,"Оригинальные лазерные картриджи HP с технологией JetIntelligence обеспечивают печать рекордного количества страниц с высокой скоростью. Можно выбрать доступные по цене модели с увеличенной емкостью.
 Инновационная технология защиты от подделок гарантирует неизменно высокое качество HP.",20,40000,20,20,20,1),
(21,5,11 PrintHeads,5,"Оригинальные лазерные картриджи HP с технологией JetIntelligence обеспечивают печать рекордного количества страниц с высокой скоростью. Можно выбрать доступные по цене модели с увеличенной емкостью. Ин
новационная технология защиты от подделок гарантирует неизменно высокое качество HP.",21,8768,21,21,21,1),
(22,5,10 Cartrige,2,"Оригинальные лазерные картриджи HP с технологией JetIntelligence обеспечивают печать рекордного количества страниц с высокой скоростью. Можно выбрать доступные по цене модели с увеличенной емкостью. Инн
овационная технология защиты от подделок гарантирует неизменно высокое качество HP.",22,7620,22,22,22,1),
(23,1,Монитор HP 27F Europe,5,"Этот сверхтонкий монитор с невероятно тонкими рамками, широчайшим углом обзора и встроенной аудиосистемой обеспечивает четкое изображение потрясающего качества, о котором вы давно мечтали. От п
росмотра веб-контента до развлечений в режиме реального времени - вы сможете увидеть мир совершенно по-новому.",23,23100,23,23,23,1),
(24,1,Монитор HP 24F Europe,3,"Этот сверхтонкий монитор с невероятно тонкими рамками, широчайшим углом обзора и встроенной аудиосистемой обеспечивает четкое изображение потрясающего качества, о котором вы давно мечтали. От п
росмотра веб-контента до развлечений в режиме реального времени - вы сможете увидеть мир совершенно по-новому.",24,21100,24,24,24,1),
(25,1,Монитор OMEN X 27,4,"Ты играешь. Мы это показываем.
Может кого-то устраивает компромисс между скоростью и качеством изображения? Но только не тебя. Погрузись с головой в игру с быстрой частотой обновления экрана 165 Гц. Оцени плавный и непрерывный игровой процесс благодаря времени от
клика 1 мс при включении функции Overdrive.",25,49540,25,25,25,1),
(26,1,Монитор HP X32 Gaming,5,"Играй лучше, дольше и комфортнее на наших превосходных игровых мониторах. Открой для себя заново игры высокой четкости благодаря экрану IPS, частоте 165 Гц, времени отклика 1 мс2, технологии AM
D3 FreeSyncT Premium4 и недостижимому ранее количеству цветов.",26,65700,26,26,26,1),



