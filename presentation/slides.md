---
theme: ./mathema-2023
defaults:
  layout: "default-with-footer"
title: 'Wir testen. Aber testen wir auch gut genug?'
occasion: "DWX 2024"
occasionLogoUrl: "./images/logo_dwx24.png"
company: "MATHEMA GmbH"
presenter: "Patrick Drechsler"
contact: "patrick.drechsler@mathema.de"
info: |
  ## Mutation testing
canvasWidth: 980
layout: cover
transition: slide-left
mdc: true
download: true

src: ./pages/00-title.md
---

---
src: ./pages/01-intro.md
---

---

## TODO Intro: Testing

- Unit test
- Integration test
- End-to-End test

Test pyramid

TDD, BDD, etc

---

## TODO Test coverage

todo

---

## TODO What is mutation testing?

TL; DR: Mutation testing introduces changes to your code, then runs your unit tests against the changed code. It is expected that your unit tests will now fail. If they don't fail, it might indicate your tests do not sufficiently cover the code.

Bugs, or mutants, are automatically inserted into your production code. Your tests are run for each mutant. If your tests fail then the mutant is killed. If your tests passed, the mutant survived. The higher the percentage of mutants killed, the more effective your tests are.

It's that simple.

(Source: [https://stryker-mutator.io/docs/](https://stryker-mutator.io/docs/))

---

### TODO Simplified Workflow

```csharp
public string DoMagic(int i)
{
  // TODO
}
```


---

## Other languages

- Java
- JavaScript
- etc.


---
src: ./pages/99-end.md
---
