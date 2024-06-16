ZZ Order Management

To create a simple order Management system, to allow the creation, deletion and completion of orders managed through a list filtered to open orders.

Implementionation, as per the specificiation using ASP MVC core using Entity Framework persisting data to a locally held SQLite database.

Method, allowing the modification of the database structure using code first, by the application of Entity Framework, add migration and update database.

Progress, my approach (albeit slow going, picking up speed towards the end of the process) was to open a new project in visual studio, this gave the basis for the projecting including JavaScript libraries like Bootstrap. Adding the libraries required to support SQLite using package manager. Source control, using the natively integrated client for GitHub.  After getting past the intial fight of flight instinct, took a deep breath and reread the specification.  Using Microsoft's MSDN libraries and training materials i was picking through the problem. 

First step was to define skeleton classes and data annotation, to model the database proving the connection and ensure the database file creation was in the correct location.  Then to generate an Order Controller using scaffolding process to for code and pages. Data Annotation would provide model validation and implementing UI javascript feedbase to the user.  However I ran into a DBContext error, which kinda slowed/killed the progress.

How i would have continued, any business logic or common functionailty would be extracted to separate class, in this case, or project in a more formal.

I did surprise myself, that towards the end of the time period this started to come together and work towards.  I was planning on leaning heavily on EF to manage the database design and data access.  I prefer to only use stored procedures access to the database from the application/user account adding a layer or application security and validation.

additional future functionality,
1, order form restricted to a products table.
2, adjust stock levels, and accounts department.
3, packaging management, select box type for dimensions and weight, allowing the shipment to go out as a single or multi-package.
4, api, to book logistics to book parcel collection and retrieve cost of delivery.
5, Warehouse management, add processes to enable put-away, pick process, quality and fulfilment.
6, barcoding, stock and location to increate accuracy.
7, stock managemnt, re-order levels/triggers, quality, inventory valuation.
8, customer portal to track shipment, using api to retrieve updates from courier.
9, user control, limiting access to user/group.  restricing employee access to data and process.
10, cookie control.

Testing, sorry didn't get that far but a test project would be added to he solution to provide sufficient/efficient code coverage to increase confidence that the project.  I'm not looking for 100% code coverage, as this is generally a waste of effort and isn't usually achievable.  Selenium, can be used to automate the testing of the UI.

Ethos, I try to write code for the next person.  Generally using longer descriptive names in the project, adding comments where required to add clarity to purpose or action to what the the code is trying to do and where necessary why, decisions where made.

regards,

James
