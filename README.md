# dotnet-core-microservices-CQRS-pattern

# Database Patterns

Problem: While defining database architecture for microservices, following concerns must be addressed
- services must be loosly coupled and developed, deployed & scaled independetly
- business transactions may enforce invariant that span multiple services
- some buiness transactions need to query that is owned by multiple services

Solution: there are many patterns to rescue above concernes
- database per service
- shared database
- CQRS (Command Query Responsibility Segregation)
- Saga Pattern

CQRS Pattern
Command Query Responsibility Segregation
It is a design pattern that seprate the read and write operation of a data source
command refers to a database command which can be either an insert / delete or update opearation
where as query stands for quering data from a source

Pros of CQRS Pattern
- sepration of concern
- better scalability
- better performance
- optimize data model


cons of CQRS pattern
- Added complexity
- evential consitency


