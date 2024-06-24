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

## "Metrics"

[https://www.nngroup.com/articles/campbells-law/](https://www.nngroup.com/articles/campbells-law/)

<v-clicks>

- "It is wrong to suppose that if you can't measure it, you can't manage it - **a costly myth**." - W. Edwards Deming
- **Campbell's Law** states that **the more important a metric is** in social decision making, the **more likely it is to be manipulated**. 
- **Goodhart's Law**, states that "**When a measure becomes a target, it ceases to be a good measure**"  

</v-clicks>

---

## Test coverage

- defines the percentage of covered code
- 100% test coverage means, every line of code is executed at least once
- 100% test coverage does not mean that every scenario / use-case is covered

---

## Is Test coverage a good metric?

- not every line of code needs to be tested
- BUT: having no tests is obviously also not a good idea
- anything above 60% is a good baseline ("it depends")
- test coverage does not tell us anything about the **quality** of the tests

<img
  class="absolute bottom-20 left-5 w-80"
  src="/images/meme-failing-tests-1.gif"
/>
<img
  class="absolute bottom-15 left-87 w-70"
  src="/images/meme-failing-tests-2.gif"
/>
<img
  class="absolute bottom-20 right-5 w-80"
  src="/images/meme-failing-tests-3.gif"
/>

---
layout: image
image: /images/whos-testing-the-tests-meme.jpg
backgroundSize: contain
---

---

## What is mutation testing?

[https://stryker-mutator.io/docs/](https://stryker-mutator.io/docs/)

<v-clicks>

- Mutation testing **introduces changes to your code**, then runs your unit tests against **the changed code**. 
- the "change" is called a **mutant**
- If our test suite is ok for a "mutant:" Ups, we missed something

</v-clicks>



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

Test suite (**100% code coverage!**):

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
layout: image-right
image: "/images/cute-zombie4.jpg"
---

## Mutations

Let's have a look at mutations: [https://stryker-mutator.io/docs/stryker-net/mutations/](https://stryker-mutator.io/docs/stryker-net/mutations/)

Most mutations are language agnostic. Some are optimized for C#:

- [Initializers](https://stryker-mutator.io/docs/stryker-net/mutations/#initialization-initializer)
- [Removal](https://stryker-mutator.io/docs/stryker-net/mutations/#removal-mutators-statement-block)
- [Linq](https://stryker-mutator.io/docs/stryker-net/mutations/#linq-methods-linq)
- [Null-coalescing Operators](https://stryker-mutator.io/docs/stryker-net/mutations/#null-coalescing-operators-nullcoalescing)

---

## Isn't this slow?

- Short answer: YES
- The mutation testing framework has to recompile the production code for every mutation!
- BUT: **These frameworks have smart heuristics for short circuiting**
- CI: Don't include this in normal commits
- CI: "Nightly", or local (for exploratory analysis)
- Google uses Mutation Testing on really large projects: https://research.google/pubs/practical-mutation-testing-at-scale-a-view-from-google/
  - It is still slow

<img
  class="absolute top-5 right-50 h-25"
  src="/images/snail-pixabay.webp"
/>


---

## Live coding

<img
  class="absolute top-5 right-50 h-125"
  src="/images/cute-zombie3.png"
/>


---

## Reports: HTML (Overview)

<img
  class="absolute bottom-40 right-30 h-70"
  src="/images/report-example-overview-html.png"
/>

---
 
## Reports: HTML (Details)

<img
  class="absolute top-30 left-30 h-100"
  src="/images/report-example-details-html.png"
/>

---
layout: two-cols-header
clicks: 7
---

## Other Reporters

::left::

<v-clicks>

- [Progress](https://stryker-mutator.io/docs/stryker-net/reporters/#progress-reporter)
- [Dashboard (?)](https://stryker-mutator.io/docs/stryker-net/reporters/#dashboard-reporter)
- [Cleartext](https://stryker-mutator.io/docs/stryker-net/reporters/#cleartext-reporter)
- [Cleartext tree](https://stryker-mutator.io/docs/stryker-net/reporters/#cleartext-tree-reporter)
- [Dots (for CI)](https://stryker-mutator.io/docs/stryker-net/reporters/#dots-reporter)
- [Json (basis for HTML)](https://stryker-mutator.io/docs/stryker-net/reporters/#json-reporter)
- [Markdown](https://stryker-mutator.io/docs/stryker-net/reporters/#markdown-summary-reporter)

</v-clicks>

::right::

<img v-click="[1]"
  class="absolute top-10 h-70"
  src="/images/report-example-overview-progress.png"
/>

<img v-click="[2]"
  class="absolute top-10 h-75"
  src="/images/stryker-dashboard.png"
/>

<img v-click="[3]"
  class="absolute top-10 h-75"
  src="/images/report-example-overview-cleartext.png"
/>

<img v-click="[4]"
  class="absolute top-10 h-125"
  src="/images/report-example-overview-cleartexttree.png"
/>

<img v-click="[5]"
  class="absolute top-10 h-10"
  src="/images/report-example-overview-dots.png"
/>

<div v-click="[7]" style="font-size: 35%">

| File                                   | Score   | Killed | Survived | Timeout | No Coverage | Ignored | Compile Errors | Total Detected | Total Undetected | Total Mutants |
| -------------------------------------- | ------- | ------ | -------- | ------- | ----------- | ------- | -------------- | -------------- | ---------------- | ------------- |
| 00\_FizzBuzz\/FizzBuzzer.cs            | 100.00% | 14     | 0        | 0       | 0           | 4       | 0              | 14             | 0                | 18            |
| 01\_CaptainObvious\/SomeService.cs     | 75.00%  | 6      | 2        | 0       | 0           | 1       | 0              | 6              | 2                | 9             |
| 02\_OrderProcessing\/OrderProcessor.cs | 72.73%  | 8      | 3        | 0       | 0           | 3       | 0              | 8              | 3                | 14            |
| 03\_Palindrome\/PalindromeChecker.cs   | 50.00%  | 2      | 2        | 0       | 0           | 2       | 1              | 2              | 2                | 7             |

</div>

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

## Fine-Tuning

Stryker provides many bells & whistles for fine-tuning using either [CLI or config file](https://stryker-mutator.io/docs/stryker-net/configuration/).

Some examples:

- [`mutate`](https://stryker-mutator.io/docs/stryker-net/configuration/#mutate-glob): Globbing patterns for including/excluding
- [`test-case-filter`](https://stryker-mutator.io/docs/stryker-net/configuration/#test-case-filter-string): filter selective subset(s) of tests
- [`mutation-level`](https://stryker-mutator.io/docs/stryker-net/configuration/#mutation-level-level): high level categories (`Basic`, `Standard`, `Advanced`, `Complete`)
- [`coverage-analysis`](https://stryker-mutator.io/docs/stryker-net/configuration/#coverage-analysis-string): short circuit logic vs "everything in isolation"

Also nice: use git as baseline, only test things that have changed recently

- [`since`](https://stryker-mutator.io/docs/stryker-net/configuration/#since-flag-committish): git "committish" (i.e. commit hash, tag, etc)
- [`with-baseline`](https://stryker-mutator.io/docs/stryker-net/configuration/#with-baseline-flag-committish) (experimental): similar to `since`, but uses previous reports

---

## Available in many languages

- JavaScript: https://stryker-mutator.io/docs/stryker-js/
- Scala: https://stryker-mutator.io/docs/stryker4s/
- Java: https://pitest.org/
- Python: https://mutatest.readthedocs.io
- etc (search for "your-programming-language mutation test")

---
clicks: 4
---

## Mutation Testing: Summary

<v-clicks>

- none-invasive: no code changes required!
- great for finding corner cases
- requires a lot of resources: use wisely
- great addition to our "Testing Toolbelt":
  - Test-Driven Development (TDD)
  - Approval Testing
  - Property-Based Testing (PBT)

</v-clicks>

<img v-click="[4]"
  class="absolute top-40 right-20 w-100"
  src="/images/toolbelt.png"
/>


---
src: ./pages/99-end.md
---
