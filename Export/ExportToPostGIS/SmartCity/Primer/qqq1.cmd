@echo off
set url="https://xn--d1ab1b.xn--73-6kc3bbqg7ac.xn--p1ai/api/v1/"
set token="eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjgyMDMzZjhkLWMxOWQtZWExMS04MGU5LTBjYzQ3YTEzODk4YiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJBLmtpcmlsbG92IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoib3JnLmFkbWluIiwiZXhwIjoxNjE2NjkwMjcxLCJpc3MiOiJBSVMuRURTIiwiYXVkIjoiYWlzZ29yb2QifQ.vaBfDRSON0CsZ_R0EWOi5A30fp9MbWUBGOWjnNibneQ"
rem curl -X GET "%url%Organizations" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"

curl -X GET "%url%Shutdowns" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"

echo 0

rem curl -X GET "%url%Tickets" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"

echo 1
rem curl -X GET "%url%Shutdowns/19/AddressLinks" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"

echo 2
rem curl -X GET "%url%Shutdowns/19/Addresses" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"

echo 3
rem curl -X GET "%url%Shutdowns/19" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"

echo  4
rem curl -X GET "%url%DamageTypes" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"