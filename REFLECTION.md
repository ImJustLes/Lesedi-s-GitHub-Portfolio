# REFLECTION

--------------------------------
IMPORTANT:

If you would like to attempt to attempt to download and run the application, please note that the placement of files are not in their correct places. In order to run the application you will need to follow the following instructions:

1) Download the files.
2) Extract the folder.
3) Go into the PROG7311POEPART2 Folder (the folder that contains the solution and README file for the project).
4) Create a folder called "PROG7311POEPART2".
5) Go back to the root unzipped folder and move all the files that are outside of the PROG7311POEPART2 folder (not the one you just created) and move them into the newly created PROG7311POEPART2 folder that you created.
6) Follow the README file for additional instructions to get the application functionable.
7) If unable to get application working, please contact me to send a video of the working application.
----------------------------------

CONTEXT:

"The primary goal of this POE is to create a digital ecosystem where farmers, green enery experts, and enthusiasts can collaborate, share resources, and innovate in the realms of sustainable agriculture and renewable energy."
“As part of the Agri-Energy Connect Platform project, you are tasked to develop a prototype web application using Visual Studio and C#. This prototype is a crucial component of your proposal and should demonstrate a functional model of the intended final product.”

Functionality Requirements:

* Database development and integration: Design a relational database to store information about farmers and their products. Also, populate the database with sample data for demonstration purposes.
* User role definition and authentication system: Develop two user roles: Farmer and Employee.  
    * Farmer: Add products to their profile and view their listings.
    * Employee: Add new farmer profiles, view all products from specific farmers, and filter products based on criteria.
* Functional features for farmers and employees:
    * Farmer: Add new products with details like name, category, and production date.
    * Employee: Add new farmer profiles with essential details and view and filter a comprehensive list of products from any farmer based on criteria such as date range and product type.
* User interface design and usability: Design a user-friendly interface that is easy to navigate and accessible on various devices.
* Ensure data presentation is clear and accurate, avoiding any ambiguity or errors.
* Incorporate data validation checks.
* Implement error-handling mechanisms.

My first ever MVC project for an assignment was almost a train smash. It was my 2nd year in my first semester. We started learning C# and we got an assignment for our cloud development module and we were told to make a website using MVC. Everyone was stressed and confused, the lecturer just gave us a video to refer to for guidance on completing the assignment, the lecturer was incapable of figuring out issues for people if we reached out to him. It was a hard time. Before then, the most complex applications we worked on were WPF applications (we still did WPF in my 2nd year for assigments and in lectures). This opened my eyes to how painfully complicated programming could be and how not have the right resources and/or people to help you learn and tackle challanges. This is why you often find that there are a team of IT people and rarely any people in IT working projects alone in the working world. Fortunately, for me, I have improved much drastically from then and can, confidentally, say that I have a MUCH better understanding of C# MVC then I did last year and it is evident in my project.

Front-end is, as of right now, a definite weakness for me, in the sense of creativity. I'm by no means a graphic designer but I am fully capable of making a login page in Bootstrap if you asked me. It wouldn't look the best, but it would function as intended. So I decided to go and find front-end that I believe would have suited my project on CodePen. I ended up settling with this: https://codepen.io/colorlib/pen/rxddKy. It doesn't function the same as the link entails, but I made a work around for it so that it still has the look, but still does what it needs to do.

With my deeper understanding of bootstrap and C#, I've managed to make changes and replace interactions in the template provided by Visual Studio for the project.

I spent a lot of time looking at my past MVC projects because the demands of this project were similar to what I've done before and its far more efficient than redoing code that I already have access to. I even managed to further optimize the code that I've done before and I wouldn't be surprised if it could be optimized further for performance.

I have not yet receieved my mark for this project but I am overall happy with the results of my labor for it. I even went as far to implement a desgin pattern (which was quite difficult to do), library for methods that I used throughout my project like encryptions and inserting and retrieveing data from my SQL database and a register page.

Even though I'm satified with what I've accomplished here, I can point a few things that can do with some improvement like:

* Implementing only one register and login page. I thought it would be less time-consuming to implement seperate logins because there are 2 different user roles for the project. Having it so that farmers and employees can login in with the same login page instead seperate ones for seperate roles.
* Implementing the CodePen UI, completely. When the user would click on the "create an account" reference on the CodePen UI, it would flip to the register and vice versa. I couldn't make it so that the register and login where on the same page and would do the same animation when switching betweem the two which is another reason as to why I did seperate logins for the different user roles.
* Having a deeper understanding of design patters. I did implement the singleton design patter for creating an instance of the database, but its not a pattern that I quite understand the logic of.
* Making the pages more personalised. I could have had so that it displays the current user logged into the website somewhere in the UI just to make it more personalised.
* Better names for properties and tables in my database. The names don't really explain the purpose as well as I would like them to. One of my tables is called "EmployeeFarmer" which doesn't entirely reflect its purpose of storing products made by farmers.

  In the future, I would like to learn one front-end language. Most likely HTML. This has pushed me to learn more about front-end and how it works.
