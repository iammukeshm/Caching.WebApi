# Caching is ASP.NET Core

## What is Caching?

Caching is a technique of storing the frequently accessed/used data so that the future requests for those sets of data can be served much faster to the client.

In other terms, you take the most frequently used data, which is also least-modified, and copy it temporary storage so that it can be accessed much faster for the future calls from the client. This awesome technique can boost the performance of your application drastically by removing unnecessary and frequent requests to the data source.

Theoretically, this is how caching would work. Client 1 requests for some data and takes about 20 seconds to fetch. While fetching, we will also parallelly copy this fetched data to temporary storage. Now, when Client 2 requests for the same data, it would just take him less than 1-2 seconds before he gets a response.

## Types of Caching
- In-Memory Caching - Where the cached data is stored within the application instance.
- Distributed Caching - where the cached data is stoerd on an external infrastructure like a Redis Server.

## In-Memeory Caching
The Topics covered are as follows.

- What is Caching?
- Caching in ASP.NET Core
- What is In-Memory Caching in ASP.NET Core?
- Pros and Cons of In-Memory Caching
- Endpoint to Get / Set Cache in Memory
- Practical Cache Implementation

Read the Entire Article here - 
https://www.codewithmukesh.com/blog/in-memory-caching-in-aspnet-core/


## Distributed Caching

Here are the topics covered.

- What is Distributed Caching in ASP.NET Core?
- Pros & Cons of Distributed Caching
- IDistributedCache interface
- What is Redis?
- Setting up Redis on Windows 10
- Getting to know Redis Better
- Redis CLI Commands
- Integrating Redis Caching in ASP.NET Core

Read the entire article here - 
https://www.codewithmukesh.com/blog/redis-caching-in-aspnet-core/
