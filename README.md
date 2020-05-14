# Panviva.Sdk

## Introduction
This is a simple .Net Core library provided by [Panviva Pty. Ltd.](https://www.panviva.com/) to help use Panviva APIs reliably and easily in a .Net Core developer environment.

This is the Base Repository of Panviva.Sdk which includes
- Panviva.Sdk.Models
- Panviva.Sdk.Services.Core

## Package Status

| Package | Downloads | Version |
|:-----------|:-----------:|:-----------:|
| Panviva.Sdk.Models |  ![Nuget](https://img.shields.io/nuget/dt/Panviva.Sdk.Models) | ![Nuget](https://img.shields.io/nuget/v/Panviva.Sdk.Models?label=Panviva.Sdk.Models) |
| Panviva.Sdk.Services.Core | ![Nuget](https://img.shields.io/nuget/dt/Panviva.Sdk.Services.Core) | ![Nuget](https://img.shields.io/nuget/v/Panviva.Sdk.Services.Core?label=Panviva.Sdk.Services.Core) |
  

# Setup For Panviva.SDK in a .Net core Environment
### Prerequisites
- Get Panviva SDK response models library package from [here](https://www.nuget.org/packages/Panviva.Sdk.Models/).
- Get Panviva SDK .Net Core NuGet package from [here](https://www.nuget.org/packages/Panviva.Sdk.Services.Core/).
    > Note : Instructions on how to install NuGet packages can be found [here](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio).

### Setting up .Net Core project
1. Import necessary using statements.
	```c
	using  Panviva.Sdk.Models.V3.Get;
	using  Panviva.Sdk.Services.Core.Extensions.V3;
	using  Panviva.Sdk.Services.Core.Exceptions;
	```

1. Add configs to appsettings ( Or you can have runtime configuration which is shown in later in this document ).
	```json
	"PanvivaApi": {
        "BaseUrl": "https://{something}.panviva.com",
        "Instance": "--Instance--",
        "ApiKey": "--Api key--",
        "RetryCount": "--RetryCount--"
	}
	```
	> Note: 
	Base Url is optional by default it will be `https://api.panviva.com`. 
	You can provide a value to override the default. 
	RetryCount is optional, If not specified the libary will use the default retry count of **3**.
    

1. Add middleware and Service.
	- To Configure method
        ```c#
        	app.UsePanvivaExceptionMiddleware();
        ```

	- To ConfigureServices method

        ```c#
        services.AddPanvivaApis();
        ```

1. Inject the handlers you want to use.

	```c#
	public MyClassConstructor(IQueryHandler queryHandler, ICommandHandler commandHandler)
        {
		_queryHandler = queryHandler;
		_commandHandler = commandHandler;
	}		
	```

1. Using Get requests with QueryHandler

	- First add necessary usings.

        ```c#
        using Panviva.Sdk.Services.Core.Handlers.V3;
        using Panviva.Sdk.Services.Core.Domain.QueryModels.V3;
        using Panviva.Sdk.Models.V3.Get;
        ```

	- Use Query Handler to Get Api results

        ```c#
        GetDocumentQueryModel queryModel = new GetDocumentQueryModel 
        {
            Id = "123";
        } 
            
        GetDocumetResultModel resultModel = await _queryhandler.HandleAsync(queryModel);
        ```

    - If you want to have runtime configuration, Create ApiConfigModel with necessary data and pass it to handler.

        ```c#
        ApiConfigModel runtimeConfigModel = new ApiConfigModel
        {
            BaseUrl = "https://{something}.panviva.com",
            Instance = "--Instance--",
            ApiKey = "--Api key--",
            RetryCount = null,
        }

        GetDocumentQueryModel queryModel = new GetDocumentQueryModel 
        {
            Id = "123";
        } 
            
        GetDocumetResultModel resultModel = await _queryhandler.HandleAsync(queryModel, runtimeConfigModel);
        ```
        > Note: Base Url is optional by default it will be `https://api.panviva.com`. You can provide a value to override the default. RetryCount is optional, If not specified the libary will use the default retry count of **3**

1. Using Post requests with CommandHandler

	- First add necessary usings.

        ```c#
        using Panviva.Sdk.Services.Core.Handlers.V3;
        using Panviva.Sdk.Services.Core.Domain.CommandModels.V3;
        using Panviva.Sdk.Models.V3.Get;
        ```
        


	- Use Query Handler to Get Api results
        ```c#
        LiveSearchCommandModel commandModel = new LiveSearchCommandModel 
        {
            UserName = "smapleName",
            Query = "SampleQuery",
            MaximizeClient = true,
            ShowFirstResult = true,
        };
            
        LiveSearchResultModel resultModel = await _commandHandler.HandleAsync(commandModel);
        ```

    - If you want to have runtime configuration, Create ApiConfigModel with necessary data and pass it to handler.
        ```c#
        ApiConfigModel runtimeConfigModel = new ApiConfigModel
        {
            BaseUrl = "https://{something}.panviva.com",
            Instance = "--Instance--",
            ApiKey = "--Api key--",
            RetryCount = null,
        }

        LiveSearchCommandModel commandModel = new LiveSearchCommandModel 
        {
            UserName = "smapleName",
            Query = "SampleQuery",
            MaximizeClient = true,
            ShowFirstResult = true,
        };
            
        LiveSearchResultModel resultModel = await _commandHandler.HandleAsync(commandModel, runtimeConfigModel);
        ```
<br>

### Handling Exception thrown by SDK.


### Exceptions

- QueryModelException
`Throws when Query Model fails to pass validations `
    > Note : Validation logic is diffrent for each model

- FailedApiRequestException
`Throws when Http request to Panviva returns non-success result  `
    > Note : Error code is same as what is received from Panviva APIs


1. Import necessary using to get Exception classes.
    ```c#
    using  Panviva.Sdk.Services.Core.Exceptions;
    ```

2. Example exception handling
    ```c#
    try 
    {
        var resultModel = await queryhandler.HandleAsyn(queryModel);
    }
    catch(QueryModelException ex)
    {
        // When Query model validation fails.
        Console.WriteLine(ex);
        throw;
    }
    catch(FailedApiRequestException ex)
    {
        // When Panviva API results in a error.
        Console.WriteLine(ex);
        throw;
    }		
    ```

  
# Library Architecture

### Overall Architecture
![Overall Architecture](/Documentation/Images/Api%20architecture.png)


## QueryHandler flow
![ueryHandler flow](/Documentation/Images/ApiLibraryFlowQuery.png)


## CommandHandler flow


![CommandHandler flow](/Documentation/Images/ApiLibraryFlowCommand.png)


## Folder Architecture
![Folder Architecture](/Documentation/Images/FileStructure.png)



# QueryModel Attributes
<br>

<table>
    <thead>
        <tr>
            <th>Model Name</th>
            <th>Attribute Name</th>
            <th>Attribute Type</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>GetArtefactQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The id (ID) of an artefact</td>
        </tr>
        <tr>
            <td>GetContainerQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The id of a document container</td>
        </tr>
        <tr>
            <td rowspan="2" valign="top">GetDocumentQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>A document unique identifier, Document ID</td>
        </tr>
        <tr>
            <td>version (optional)</td>
            <td>integer</td>
            <td>Request the API to return a particular version of the specified document</td>
        </tr>
        <tr>
            <td>GetDocumentContainerRelationshipsQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The internal id (IID) of a Panviva document</td>
        </tr>
        <tr>
            <td>GetDocumentContainerQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The internal id (IID) of a Panviva document</td>
        </tr>
        <tr>
            <td>GetDocumentTranslationsQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The internal id (IID) of a Panviva document</td>
        </tr>
        <tr>
            <td>GetFileQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The internal id (IID) of a Panviva file (external document)</td>
        </tr>
        <tr>
            <td>GetFolderQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The internal id (IID) of a Panviva document</td>
        </tr>
        <tr>
            <td>GetFolderChildrenQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The internal id (IID) of a Panviva document</td>
        </tr>
        <tr>
            <td>GetFolderRootQueryModel</td>
            <td colspan="3">None</td>
        </tr>
        <tr>
            <td>GetImageQueryModel</td>
            <td>id</td>
            <td>string</td>
            <td>The id of a Panviva image</td>
        </tr>
        <tr>
            <td rowspan="3" valign="top">GetSearchQueryModel</td>
            <td>term</td>
            <td>string</td>
            <td>The word or phrase to be searched for</td>
        </tr>
        <tr>
            <td valign="top">pageOffset (optional)</td>
            <td valign="top">integer</td>
            <td>The pagination offset to denote the number of initial search results to skip. For example, pageOffset of 100 and pageLimit of 10 would return records 101-110</td>
        </tr>
        <tr>
            <td valign="top">pageLimit (optional)</td>
            <td valign="top">integer</td>
            <td>The number of records to return. Must be an integer between 0 and 1000</td>
        </tr>
        <tr>
            <td rowspan="6" valign="top">GetSearchArtefactQueryModel</td>
            <td valign="top">simplequery (optional)</td>
            <td valign="top">string</td>
            <td>Natural language query string. For example: `Action Movies`. (Note: Use simplequery OR advancedquery, not both.)</td>
        </tr>
        <tr>
            <td valign="top">advancedquery (optional)</td>
            <td valign="top">string</td>
            <td>Query string written in Lucene query syntax. For example: `films AND "a story"`. (Note: Use simplequery OR advancedquery, not both.)</td>
        </tr>
        <tr>
            <td valign="top">filter (optional)</td>
            <td valign="top">string</td>
            <td>Accepts a Lucene-formatted filter string. Examples: category eq 'Mortgages', panvivaDocumentVersion gt '8'. (Filterable fields include dateCreated, dateModified, dateDeleted, categoryJson, queryVariationsJson, title, category, primaryQuery, isDeleted, timestamp, panvivaDocumentId, panvivaDocumentVersion, id)</td>
        </tr>
        <tr>
            <td valign="top">channel (optional)</td>
            <td valign="top">string</td>
            <td>Return response for a specific channel, instead of the default</td>
        </tr>
        <tr>
            <td valign="top">pageOffset (optional)</td>
            <td valign="top">integer</td>
            <td>The pagination offset to denote the number of initial search results to skip. For example, pageOffset of 100 and pageLimit of 10 would return records 101-110</td>
        </tr>
        <tr>
            <td valign="top">pageLimit (optional)</td>
            <td valign="top">integer</td>
            <td>The number of records to return. Must be an integer between 0 and 1000</td>
        </tr>
    </tbody>
</table>

# CommandModel Attributes
<br>

<table>
    <thead>
        <tr>
            <th>Model Name</th>
            <th>Attribute Name</th>
            <th>Attribute Type</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>CreateArtefactCategoryCommandModel</td>
            <td>name</td>
            <td>string</td>
            <td>The name of the new category</td>
        </tr>
        <tr>
            <td rowspan="5" valign="top">LiveCshCommandModel</td>
            <td valign="top">userName</td>
            <td valign="top">string</td>
            <td>The Panviva user to whom you wish to send the result. (Note: Use username OR userId, not both.)</td>
        </tr>
        <tr>
            <td valign="top">userId</td>
            <td valign="top">string</td>
            <td>The numeric ID of the user to whom you wish to send the result. (Note: Use username OR userId, not both.)</td>
        </tr>
        <tr>
            <td valign="top">query</td>
            <td valign="top">string</td>
            <td>The CSH term to search for</td>
        </tr>
        <tr>
            <td valign="top">showFirstResult (optional)</td>
            <td valign="top">bool</td>
            <td>True to immediately open the first document found, or false to show the list of results</td>
        </tr>
        <tr>
            <td valign="top">maximizeClient (optional)</td>
            <td valign="top">bool</td>
            <td>True/False depending on whether you want the Panviva client to maximize on the user's desktop, when the document is delivered</td>
        </tr>
        <tr>
            <td rowspan="5" valign="top">LiveDocumentModel</td>
            <td valign="top">userName</td>
            <td valign="top">string</td>
            <td>The Panviva user to whom you wish to send the result. (Note: Use username OR userId, not both.)</td>
        </tr>
        <tr>
            <td valign="top">userId</td>
            <td valign="top">string</td>
            <td>The numeric ID of the user to whom you wish to send the result. (Note: Use username OR userId, not both.)</td>
        </tr>
        <tr>
            <td valign="top">id</td>
            <td valign="top">string</td>
            <td>The Document ID of the Panviva Document you wish to send</td>
        </tr>
        <tr>
            <td valign="top">location (optional)</td>
            <td valign="top">string</td>
            <td>The Section ID you would like the user to see, when the specified document is opened</td>
        </tr>
        <tr>
            <td valign="top">maximizeClient (optional)</td>
            <td valign="top">bool</td>
            <td>True/False depending on whether you want the Panviva client to maximize on the user's desktop, when the document is delivered</td>
        </tr>
        <tr>
            <td rowspan="5" valign="top">LiveSearchCommandModel</td>
            <td valign="top">userName</td>
            <td valign="top">string</td>
            <td>The Panviva user to whom you wish to send the result. (Note: Use username OR userId, not both.)</td>
        </tr>
        <tr>
            <td valign="top">userId</td>
            <td valign="top">string</td>
            <td>The numeric ID of the user to whom you wish to send the result. (Note: Use username OR userId, not both.)</td>
        </tr>
        <tr>
            <td valign="top">query</td>
            <td valign="top">string</td>
            <td>The term to search for</td>
        </tr>
        <tr>
            <td valign="top">showFirstResult (optional)</td>
            <td valign="top">bool</td>
            <td>True to immediately open the first document found, or false to show the list of results</td>
        </tr>
        <tr>
            <td valign="top">maximizeClient (optional)</td>
            <td valign="top">bool</td>
            <td>True/False depending on whether you want the Panviva client to maximize on the user's desktop, when the document is delivered</td>
        </tr>
    </tbody>
</table>
