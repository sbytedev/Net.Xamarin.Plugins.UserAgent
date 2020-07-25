# Xamarin UserAgent Plugin
![GitHub](https://img.shields.io/github/license/SByteDev/Net.Xamarin.Plugins.UserAgent.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.Xamarin.Plugins.UserAgent.svg)
[![Build Status](https://img.shields.io/bitrise/d5024e64234a3497/develop?label=development&token=X7kbS_OyVGW6PoyZu3Sbag&branch)](https://app.bitrise.io/app/d1fd3128deec4532)
[![Build Status](https://img.shields.io/bitrise/d5024e64234a3497/master?label=production&token=X7kbS_OyVGW6PoyZu3Sbag&branch)](https://app.bitrise.io/app/d1fd3128deec4532)
[![CodeFactor](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.plugins.useragent/badge)](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.plugins.useragent)

Provides a cross-platform functionality to get the current [User-Agent](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/User-Agent) value.

## Installation

Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package SByteDev.Xamarin.Plugins.UserAgent
```

## Usage
```cs
using SByteDev.Xamarin.Plugins.UserAgent;

var userAgent = await UserAgentPlugin.Instance.GetUserAgentAsync(CancellationToken.None);
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
