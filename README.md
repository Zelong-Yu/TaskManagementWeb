Simple Scanning Web App -- built with ASP.NET Core MVC 2
===============================================
### Zelong Yu
[Web version](https://github.com/himoyu/TaskManagementWeb)

[Cosole App Version](https://github.com/himoyu/TaskManagement)

[**Simple Scanning** original documentation by _Mark Foster_](http://markforster.squarespace.com/blog/2017/12/2/simple-scanning-the-rules.html)
![Alt text](SampleUse.gif?raw=true "SimpleScanning")

Introduction
------------
**Simple Scanning** is an intuitive yet powerful task management method to finish a _long list_ of tasks. The aim is to write (add) everything down that you
have to do, want to do or think you might do **without** any attempt to categorise, prioritise or emphasise any particular task in any
way. When start working, scan down the list and start working on any one task you want to work on as long as you like. If it is not finished,
cross out the original and reenter the task to the end of the list. If it is completed, simply cross it out for good. 

As time goes by, lingering uncompleted task will simply start to _stand out_ among completed tasks. Time to rethink/ reevaluate the task if 
it lingers too long. 

For suggestions refer to [**Simple Scanning** original documentation by _Mark Foster_](http://markforster.squarespace.com/blog/2017/12/2/simple-scanning-the-rules.html)


Installation
------------
1. Clone/Download the git folder to a local directory.
2. Use Visual Studio to open `TaskManagementWeb.sln`
3. Build and run.



**Simple Scanning** Use
-----
1. Click `Create New` to add new tasks. You keep adding new taskes until you click `Back to List`.
2. Select a task to action on. To cross out and reenter a task, keep `Completed` unselected and `save`. To cross out for good, tick  `Completed` and `Save`. a `Back to List` without saving. 
3. `Previous` and `Next` for page navigation. New / Reentered task will be added on end of last page.

References
----------
* [**Simple Scanning** original documentation by _Mark Foster_](http://markforster.squarespace.com/blog/2017/12/2/simple-scanning-the-rules.html)

DevLog - Task Management/Time Usage
----------
25 minutes Pomodoro Technic Used.
3/7-3/10 Tutorial Video Watching / Following  
Estimate Time: 2 days, 5 hours. Actual time: 4 days, 18 hours.
3/10 Following Microsoft offical MVC tutorial to build MVC website, create SQL Database
Estimate Time: 6 hours Actual Time: 5 hours
3/11 Implement Pagination
Estimate Time: 5 hours Actual Time: 5 hours

Conclusion: Text tutorials and MSFT Official documents are way easier to follow.

[Get started with ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.2&tabs=visual-studio)
[Tutorial: Add sorting, filtering, and paging - ASP.NET MVC with EF Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-2.2)
DevLog - Next Step
----------
- Create and link existing DB
- Implement FVP 
- Style up the website with bootstrap
