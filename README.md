# resturant-for-you

init steps 

in console 
:remote connect tinkerpop.server conf/remote.yaml session
:remote console

add a city 
g.addV("city").property("Name","Bangalore").property("AreaCode","560").next()