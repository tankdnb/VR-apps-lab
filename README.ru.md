# VR-apps-lab

[English](README.md) | Русский

`VR-apps-lab` — это публичный `репозиторий знаний`, `pattern library` и
`working lab` для VR-утилит, overlay-инструментов, diagnostics, tracking
helpers, runtime tools и experimental XR integrations.

Репозиторий нужно воспринимать не как одну программу, а как системную базу
изученных решений и переиспользуемых подходов.

## Что здесь находится

- канонический registry изученных VR-репозиториев
- каталог reusable methods и product patterns
- family-группы и wave-документы по исследовательским срезам
- reuse plans для самых ценных donor-репозиториев
- operating docs для повторяемой research-работы
- вспомогательные repo-level workflows и research scripts

## Чем этот репозиторий не является

Это не:

- один готовый VR-продукт
- репозиторий, где нужно “дописать главное приложение”
- обещание production-ready поддержки всех headset/runtime комбинаций
- плоский список ссылок без систематизации

## С чего начать

- [AGENTS.md](AGENTS.md)
- [Индекс документации](docs/README.ru.md)
- [Documentation Index (EN)](docs/README.md)
- [Repository Positioning](docs/foundation/repository-positioning.md)
- [Current Operating Context](docs/foundation/current-operating-context.md)
- [Platform Foundation](docs/foundation/platform-foundation.md)
- [Research Docs](docs/research/README.md)
- [Methods Catalog](docs/research/methods/vr-utility-methods-catalog.md)
- [Project Families](docs/research/landscape/project-families.md)
- [Project Registry](docs/research/catalog/project-registry.md)
- [Not Yet Studied Deeply](docs/research/landscape/not-yet-studied-deeply.md)
- [New Session Quickstart](docs/research/program/new-session-quickstart.md)

## Структура репозитория

```text
docs/
  foundation/   позиционирование, roadmap, operating context
  research/     catalog, families, waves, methods, reuse plans

scripts/
  research/     helper scripts для повторяемой research-работы
```

Mainline-ветка репозитория сознательно сосредоточена на `foundation` и
`research`-слоях. Если в будущем появятся полезные donor-ready примеры или
малые прототипы, они должны усиливать репозиторий, а не снова превращать его в
один app-first проект.

## Как здесь проверяются изменения

Для `research` и `documentation` изменений главное:

- целостность структуры
- понятная навигация
- согласованность `registry / families / methods / backlog`
- честное описание реальных границ репозитория

Если когда-нибудь добавляется runnable example, проверять нужно только
затронутый пример, а не воображаемое “главное приложение”.

## Навигация по документации

Главный индекс: [docs/README.md](docs/README.md) и
[docs/README.ru.md](docs/README.ru.md).

Для research-системы основной вход:
[docs/research/README.md](docs/research/README.md).

## Лицензия

Репозиторий распространяется под `MIT`. Актуальный статус third-party notices
описан в [THIRD_PARTY_NOTICES.md](THIRD_PARTY_NOTICES.md).
