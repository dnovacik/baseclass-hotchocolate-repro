# baseclass-hotchocolate-repro

## Operation
```graphql
mutation addPage($page: PageInputType!) {
  addPage(page: $page) {
    sections {
      ...on MediaSectionType {
        title {
          value
        }
        content {
          content {
            url
          }
        }
      },
      ...on TextMediaSectionType {
        title {
          value
        }
      }
    }
  }
}
```

## Variable
```json
{
  "page": {
    "sections": [
      {
        "media": {
          "title": {
            "value": "Tajtl"
          },
          "content": {
            "content": {
              "url": "https://pbs.twimg.com/profile_images/1403630679271870467/69inDNY__400x400.jpg"
            }
          }
        }
      },
      {
        "textMedia": {
          "title": {
            "value": "Tajtl 2"
          },
          "content": [
            {
              "media": {
                "content": {
                  "url": "https://pbs.twimg.com/profile_images/1403630679271870467/69inDNY__400x400.jpg"
                }
              }
            },
            {
              "text": {
                "content": [
                  {
                    "text": {
                      "textContentValue": {
                        "text": "Hantoka",
                        "type": "BOLD"
                      }
                    }
                  }
                ]
              }
            },
            {
              "divider": {
                "dividerLength": "SHORT",
                "dividerType": "SOLID"
              }
            }
          ]
        }
      }
    ]
  }
}
```
