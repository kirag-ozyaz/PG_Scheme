set Login=a.kirillov
set Pwd=Ulges73!
rem set token="eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjgyMDMzZjhkLWMxOWQtZWExMS04MGU5LTBjYzQ3YTEzODk4YiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJBLmtpcmlsbG92IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoib3JnLmFkbWluIiwiZXhwIjoxNjE2NTMxMTg5LCJpc3MiOiJBSVMuRURTIiwiYXVkIjoiYWlzZ29yb2QifQ.Ff4xOUZh6e104sj5ndIbyUr9BRJi9uPLdkvGuebMkFM"
set url="https://xn--d1ab1b.xn--73-6kc3bbqg7ac.xn--p1ai/api/v1/"
curl -X POST "%url%token" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"userName\":\"%Login%\",\"password\":\"%Pwd%\"}"
rem curl -X POST "https://xn--d1ab1b.xn--73-6kc3bbqg7ac.xn--p1ai/api/v1/token" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"userName\":\"a.kirillov\",\"password\":\"Ulges73!\"}"
rem curl -X GET "%url%Organizations" -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"
rem curl -X GET "%url%Tickets"  -H "ContentType:  application/json" -H "Accept: text/plain" -H "Authorization: Bearer %token%"
rem "Sequence contains no elements "