# GodelTech.StoryLine

Welcome to **GodelTech.StoryLine** framework used to create integration tests!

This [wiki](https://github.com/GodelTech/GodelTech.StoryLine/wiki) is the main source of documentation for developers working with (or contributing to) the **GodelTech.StorLine** project.

**GodelTech.StoryLine** project defines base classes and interfaces used to construct test scenarios. It's very unlikely that this library can be used alone. It's expected that library is used with conjunction with one of the following libraries which provides specific actions and expectations:

* [GodelTech.StoryLine.Rest](https://github.com/GodelTech/GodelTech.StoryLine.Rest) is a set of REST-specific actions which simplify testing of HTTP-based services.
* [GodelTech.StoryLine.Rest.Coverage](https://github.com/GodelTech/GodelTech.StoryLine.Rest.Coverage/) tool can be used to measure REST API test coverage level.
* [GodelTech.StoryLine.Wiremock](https://github.com/GodelTech/GodelTech.StoryLine.Wiremock) is a set of [WireMock](http://wiremock.org/)-specific actions and expectations. This library can serve as WireMock client which is compatible with **GodelTech.StoryLine** framework.
* [GodelTech.StoryLine.Utils](https://github.com/GodelTech/GodelTech.StoryLine.Utils) is a set of helper actions and expectations which are not specific to any area.

