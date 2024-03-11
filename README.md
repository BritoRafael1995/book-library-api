# book-library-ui



To run application do the steps bellow: 

-open package manager console and run the command "update-database". this will create the database through EF Core, using the migrations.
-run the application using iis.
-on the oppened swagger page, open the dataSeed method, click on "Try it out" and them click on "Execute", this will populate the database with the sample values.



I chose to change the db modeling a little, thinking about some scenarios different from those highlighted on the assesstment, such as the possibility of having multiple categories or authors for the same book.