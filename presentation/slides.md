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
layout: two-cols-header
clicks: 2
---

### Hello-World Example

::left::

Production code:

```csharp
public string DoMagic(int i) => i < 18 ? "child" : "adult"
```

<div v-click>

- `dotnet stryker`
- it creates a mutant replacing `<` with `<=`

```csharp
public string DoMagic(int i) => i <= 18 ? "child" : "adult"
```

</div>

<arrow v-click="[1]" x1="312" y1="110" x2="312" y2="140" color="red" width="2" arrowSize="1" />
<arrow v-click="[1]" x1="315" y1="310" x2="315" y2="280" color="red" width="2" arrowSize="1" />

<div v-click="[2]">

- The mutant "survived"
- The mutant did not provoke a test failure!
- ⚠️ Our test suite might not be good enough! ⚠️

</div>

::right::

Test suite (100% code coverage!):

```csharp
[Theory]
[InlineData(10, "child")]
[InlineData(20, "adult")]
public void DoMagic_works(int input, string expected)
{
  DoMagic(input).Should().Be(expected)
}
```

<style>
.col-bottom {
  align-self: end;
  grid-area: 3 / 1 / 4 / 3; /* Adjust this to correctly place the bottom area */
}
.two-cols-header {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  grid-template-rows: auto 1fr auto;
  column-gap: 20px; /* Adjust the gap size as needed */
}
</style>


---

## Other languages

- Java
- JavaScript
- etc.


---
src: ./pages/99-end.md
---
