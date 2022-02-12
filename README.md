# Restaurant For You!!

### Motivation 
The main motivation to create this project was to try out some-other form of database apart from the ones like mysql, mongoDb and explore a new style of data storage which is 'Graph Db'. Idea was to see how well graph db works and how easy it is to integrate it with some api project written in c# or java. As I am more comfortable in C# hence the api project is a .net core api. 

### Concepts used
Concepts that I have tried to use and explore while writing the code are 
* Use of DDD approach while designing the api project and also the schema of the graph-db. 
* Explore clean coding approaches and also put a flavour of funcitonal programming on top of Object Oriented Design. 
* See how we can perform all the db operations that we could easily in mysql and mongoDb using this graph-db. 
* Main agenda is to see if using graph db is really effective or not. 

### What the project does 
The project is a simple recomender system which recommends the users some restaurants according to their ratings and also according to the ratings that the user's friends have liked or rated high. 

### Why choose this use case
I read in books and blogs that systems related to social media and recommender system is where, graph dbs out perform others.It is seen that while creating recommendation systems we have lots of entity connectivity which can lead to lots of table joins and using concepts of graphs in 'graphDb' we can make those old style complex join queries more easier and faster.  

### Steps to design the project 

#### Domain model of the project

When I say Domain, I mean the entities that the users will be directly interacting with. Like 

1. User Model ->  as users will follow other users, users can see their profile. 
2. Restaurant -> This entity is something the user will directly interact with. 
3. Review -> User will write a review about a restaurant. 
4. Location -> This is something both user and restaurant interact with. So, even location makes it to the domain layer. 

One good thing about Db schema and the domain model that we write for our backend is both follow the same structure and this way we can use the same design to design both 
backend and db schema. 

Below is the layout how the graph db will look and these entities will also get mapped as domains in the backend code as well. This are the initial basic entities which we have and will grow as we bring more recommeder intellignece into the project.  
<br>
![image](https://user-images.githubusercontent.com/15065217/153732354-dd8b659e-0a5a-4f7d-993e-ff8c73283756.png)
<br>


