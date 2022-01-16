# resturant-for-you

init steps 

in console 
:remote connect tinkerpop.server conf/remote.yaml session
:remote console

g.V().drop()

add a city 
excel formula : =CONCAT("g.addV('city').property('Name',' ",A1,"').property('AreaCode','",B1,"').next()")



C1=g.addV('city').property('Name',' Audugodi').property('AreaCode','560030').next()
C2=g.addV('city').property('Name',' Airforce Station (Yelahanka)').property('AreaCode','560063').next()
C3=g.addV('city').property('Name',' Agaram').property('AreaCode','560007').next()
C4=g.addV('city').property('Name',' Anadanagar').property('AreaCode','560024').next()
C5=g.addV('city').property('Name',' Arabic College').property('AreaCode','560045').next()
C6=g.addV('city').property('Name',' Banasawadi').property('AreaCode','560043').next()
C7=g.addV('city').property('Name',' Banashankari').property('AreaCode','560050').next()
C8=g.addV('city').property('Name',' Banashankari 11 Stage').property('AreaCode','560070').next()
C9=g.addV('city').property('Name',' Banashankari 111 Stage').property('AreaCode','560085').next()
C10=g.addV('city').property('Name',' Bangalore city').property('AreaCode','560002').next()
C11=g.addV('city').property('Name',' Bangalore GPO').property('AreaCode','560001').next()
C12=g.addV('city').property('Name',' Bannerghatta').property('AreaCode','560083').next()
C13=g.addV('city').property('Name',' Bannerghatta Road').property('AreaCode','560076').next()
C14=g.addV('city').property('Name',' Basavanagudi').property('AreaCode','560004').next()
C15=g.addV('city').property('Name',' Basaveswaranagar').property('AreaCode','560079').next()
C16=g.addV('city').property('Name',' BTM Layout').property('AreaCode','560076').next()
C17=g.addV('city').property('Name',' Benson Town').property('AreaCode','560046').next()
C18=g.addV('city').property('Name',' Byatarayanapura').property('AreaCode','560092').next()
C19=g.addV('city').property('Name',' Carmelram').property('AreaCode','560035').next()
C20=g.addV('city').property('Name',' Chickpet').property('AreaCode','560053').next()
C21=g.addV('city').property('Name',' Chamrajpet').property('AreaCode','560018').next()
C22=g.addV('city').property('Name',' Chikka Banavara').property('AreaCode','560090').next()
C23=g.addV('city').property('Name',' Dasarahalli').property('AreaCode','560057').next()
C24=g.addV('city').property('Name',' Dharmavaram College').property('AreaCode','560029').next()
C25=g.addV('city').property('Name',' Doddakallasandra').property('AreaCode','560062').next()
C26=g.addV('city').property('Name',' Doorvaninagar').property('AreaCode','560016').next()
C27=g.addV('city').property('Name',' Domlur').property('AreaCode','560071').next()
C28=g.addV('city').property('Name',' Frazer Town').property('AreaCode','560005').next()
C29=g.addV('city').property('Name',' Gandhinagar').property('AreaCode','560009').next()
C30=g.addV('city').property('Name',' Gavipuram Extn').property('AreaCode','560019').next()
C31=g.addV('city').property('Name',' Govt Electric Factory').property('AreaCode','560026').next()
C32=g.addV('city').property('Name',' HAL 11 Stage').property('AreaCode','560008').next()
C33=g.addV('city').property('Name',' Hazarat Kambal Posh Rd').property('AreaCode','500051').next()
C34=g.addV('city').property('Name',' H.B.R Layout').property('AreaCode','560043').next()
C35=g.addV('city').property('Name',' Hesarghatta').property('AreaCode','560088').next()
C36=g.addV('city').property('Name',' HMT').property('AreaCode','560031').next()
C37=g.addV('city').property('Name',' Hospital Town West').property('AreaCode','560015').next()
C38=g.addV('city').property('Name',' Indian Inst.of Science').property('AreaCode','560012').next()
C39=g.addV('city').property('Name',' Indiranagar').property('AreaCode','560038').next()
C40=g.addV('city').property('Name',' Industrial Estate').property('AreaCode','560044').next()
C41=g.addV('city').property('Name',' Jayachamarajendranagar').property('AreaCode','560006').next()
C42=g.addV('city').property('Name',' Jalahalli').property('AreaCode','560013').next()
C43=g.addV('city').property('Name',' Jalahalli East').property('AreaCode','560013').next()
C44=g.addV('city').property('Name',' Jalahalli West').property('AreaCode','560015').next()
C45=g.addV('city').property('Name',' Jayanagar').property('AreaCode','560011').next()
C46=g.addV('city').property('Name',' Jayanagar South').property('AreaCode','560041').next()
C47=g.addV('city').property('Name',' Jayanagar 7th Block').property('AreaCode','560082').next()
C48=g.addV('city').property('Name',' Jayaprakasha Nagar(J.P ngr)').property('AreaCode','560078').next()
C49=g.addV('city').property('Name',' Jeevanbheemanagar').property('AreaCode','560075').next()
C50=g.addV('city').property('Name',' Kadugodi').property('AreaCode','560067').next()
C51=g.addV('city').property('Name',' Kamakshipalya').property('AreaCode','560079').next()
C52=g.addV('city').property('Name',' Kengeri').property('AreaCode','560060').next()
C53=g.addV('city').property('Name',' Koramangala').property('AreaCode','560034').next()
C54=g.addV('city').property('Name',' Kottanur').property('AreaCode','560077').next()
C55=g.addV('city').property('Name',' Krishnarajapura').property('AreaCode','560036').next()
C56=g.addV('city').property('Name',' Kumbalagod').property('AreaCode','560074').next()
C57=g.addV('city').property('Name',' Madiwala').property('AreaCode','560068').next()
C58=g.addV('city').property('Name',' Magadi Road').property('AreaCode','560023').next()
C59=g.addV('city').property('Name',' Mahadevapura').property('AreaCode','560048').next()
C60=g.addV('city').property('Name',' Mahalakshmi Layout').property('AreaCode','560086').next()
C61=g.addV('city').property('Name',' Malleswaram').property('AreaCode','560033').next()
C62=g.addV('city').property('Name',' Malleswaram West').property('AreaCode','560055').next()
C63=g.addV('city').property('Name',' Maruthihalli').property('AreaCode','560037').next()
C64=g.addV('city').property('Name',' Maruthisevanagar').property('AreaCode','560033').next()
C65=g.addV('city').property('Name',' Mattikere').property('AreaCode','560054').next()
C66=g.addV('city').property('Name',' Millar Tankbund area').property('AreaCode','560052').next()
C67=g.addV('city').property('Name',' Nagasandra').property('AreaCode','560073').next()
C68=g.addV('city').property('Name',' Nagarabavi').property('AreaCode','560072').next()
C69=g.addV('city').property('Name',' Padmanabhanagar').property('AreaCode','560070').next()
C70=g.addV('city').property('Name',' Peenya').property('AreaCode','560058').next()
C71=g.addV('city').property('Name',' Ravindranath Tg Nagar').property('AreaCode','560032').next()
C72=g.addV('city').property('Name',' Rajajinagar').property('AreaCode','560010').next()
C73=g.addV('city').property('Name',' RV Niketan').property('AreaCode','560059').next()
C74=g.addV('city').property('Name',' Richmond Town').property('AreaCode','560025').next()
C75=g.addV('city').property('Name',' Sadashivanagar').property('AreaCode','560080').next()
C76=g.addV('city').property('Name',' Seshadripuram').property('AreaCode','560020').next()
C77=g.addV('city').property('Name',' Shantinagar').property('AreaCode','560027').next()
C78=g.addV('city').property('Name',' Shivanchetti Garden').property('AreaCode','560042').next()
C79=g.addV('city').property('Name',' Srirampuram').property('AreaCode','560021').next()
C80=g.addV('city').property('Name',' St.Thomas Town').property('AreaCode','560084').next()
C81=g.addV('city').property('Name',' Subramanyanagar').property('AreaCode','560061').next()
C82=g.addV('city').property('Name',' Tavarekere').property('AreaCode','560081').next()
C83=g.addV('city').property('Name',' Thyagarajanagar').property('AreaCode','560028').next()
C84=g.addV('city').property('Name',' Vasanthnagar').property('AreaCode','560052').next()
C85=g.addV('city').property('Name',' Vijayanagar').property('AreaCode','560040').next()
C86=g.addV('city').property('Name',' Vijayanagar North').property('AreaCode','560079').next()
C87=g.addV('city').property('Name',' Vimanapura').property('AreaCode','560017').next()
C88=g.addV('city').property('Name',' Varthur').property('AreaCode','560056').next()
C89=g.addV('city').property('Name',' Vishwavidyanilaya').property('AreaCode','560087').next()
C90=g.addV('city').property('Name',' Vishwaneedam').property('AreaCode','560091').next()
C91=g.addV('city').property('Name',' Viveknagar').property('AreaCode','560047').next()
C92=g.addV('city').property('Name',' Virgonagar').property('AreaCode','560049').next()
C93=g.addV('city').property('Name',' West of Chord Road').property('AreaCode','560086').next()
C94=g.addV('city').property('Name',' Whitefield').property('AreaCode','560066').next()
C95=g.addV('city').property('Name',' Yelahanka').property('AreaCode','560064').next()
C96=g.addV('city').property('Name',' Yeshwanthpur').property('AreaCode','560022').next()



Resturants

R1=g.addV('restaurant').property('Name','Barbeque Nation').next()
R2=g.addV('restaurant').property('Name','Punjab Grill').next()
R3=g.addV('restaurant').property('Name','BonSouth').next()
R4=g.addV('restaurant').property('Name','Chutney Chang').next()
R5=g.addV('restaurant').property('Name','The Fishermans Wharf').next()
R6=g.addV('restaurant').property('Name','Nagarjuna').next()
R7=g.addV('restaurant').property('Name','Empire').next()
R8=g.addV('restaurant').property('Name','Onesta').next()
R9=g.addV('restaurant').property('Name','Truffles').next()
R10=g.addV('restaurant').property('Name','Kanua').next()




Resturants -> City

g.addE('situated_in').from(R1).to(C48).next()
g.addE('situated_in').from(R2).to(C61).next()
g.addE('situated_in').from(R3).to(C53).next()
g.addE('situated_in').from(R4).to(C45).next()
g.addE('situated_in').from(R5).to(C48).next()
g.addE('situated_in').from(R6).to(C45).next()
g.addE('situated_in').from(R7).to(C61).next()
g.addE('situated_in').from(R8).to(C61).next()
g.addE('situated_in').from(R9).to(C53).next()
g.addE('situated_in').from(R10).to(C53).next()



get restaurants that is in  users location
g.V().has("user","EmailId","best.sai21@gmail.com").out("situated_in").in("situated_in").hasLabel("restaurant").valueMap()

