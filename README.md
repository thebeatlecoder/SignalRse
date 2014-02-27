#SignalRse

I wrote this code for a blog post called [SignalRse: Load balancing the shit out of SignalR](http://scottcodes.net/blog). It's just a very
trivial example of how you can get SignalR up and running, and then scale it out horizontally using a SQL Server backplane.

There's currently no automated setup for the code, so to try it out you'll need to:

- Create an empty SQL Server database for the backplane
- Open "ScaleOut.Website.sln" and add the connection string for your database to the Web.config. You can then hit F5 to fire up the website.
- Open the "CustomerUpdateService.sln" and hit F5. Events should then start being published to the hub and you will see the names on the website updating in real-time.

If you refresh your backplane database, you should see that some tables have been created automatically. 

Obviously this doesn't definitively prove that that the backplane is working it's magic. For that you'll need to install the website in more than one place so that it 
has to deliver each message to N nodes.