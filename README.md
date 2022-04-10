# ApiLabb4
Get all persons
https://localhost:44398/api/person/all

All interest connected to a personID
https://localhost:44398/api/person/ai/{id}

All websites connected to a personID
https://localhost:44398/api/person/al/{id}

Connect a person to a new interest
https://localhost:44398/api/interest
POST > Body > raw > JSON
{"Titel":"Dogs","Description":"Dogs are the best!","personId":1}

Connect website to new person/interest
https://localhost:44398/api/website
POST > Body > raw > JSON
{"SiteURL":"www.dogs.com","interestId":8}
