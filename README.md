# LibP2P.Protocol (cs-libp2p-protocol)

[![Travis CI](https://img.shields.io/travis/libp2p/cs-libp2p-protocol.svg?style=flat-square&branch=master)](https://travis-ci.org/libp2p/cs-libp2p-protocol)
[![AppVeyor](https://img.shields.io/appveyor/ci/tabrath/cs-libp2p-protocol/master.svg?style=flat-square)](https://ci.appveyor.com/project/tabrath/cs-libp2p-protocol)
[![NuGet](https://img.shields.io/nuget/v/LibP2P.Protocol.svg?style=flat-square)](https://www.nuget.org/packages/LibP2P.Protocol)
[![NuGet](https://img.shields.io/nuget/dt/LibP2P.Protocol.svg?style=flat-square)](https://www.nuget.org/packages/LibP2P.Protocol)
[![Codecov](https://img.shields.io/codecov/c/github/libp2p/cs-libp2p-protocol/master.svg?style=flat-square)](https://codecov.io/gh/libp2p/cs-libp2p-protocol)
[![Libraries.io](https://img.shields.io/librariesio/github/libp2p/cs-libp2p-protocol.svg?style=flat-square)](https://libraries.io/github/libp2p/cs-libp2p-protocol)

> Implementation/port of [libp2p/go-libp2p-protocol](https://github.com/libp2p/go-libp2p-protocol) in C# .NET Standard 1.6 compliant.

## Table of Contents

- [Install](#install)
- [Usage](#usage)
- [Maintainers](#maintainers)
- [Contribute](#contribute)
- [License](#license)

## Install

    PM> Install-Package LibP2P.Protocol

--

    dotnet add package LibP2P.Protocol

## Usage

``` cs
var pid = new ProtocolId("/libp2p/id");
```

## Maintainers

Captain: [@tabrath](https://github.com/tabrath).

## Contribute

Contributions welcome. Please check out [the issues](https://github.com/libp2p/cs-libp2p-crypto/issues).

## License

[MIT](LICENSE) © 2017 Trond Bråthen
