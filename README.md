# F# Mutable Variable Recursive Loop Bug

This repository demonstrates a common error in F# involving mutable variables and recursive functions. The `bug.fs` file contains code that leads to an infinite loop due to improper mutation of variables.  The solution is provided in `bugSolution.fs`.  The key takeaway is to carefully manage mutable state in recursive functions to avoid unintended consequences.  Incorrect variable updates can lead to unexpected behavior or infinite recursion.

## How to reproduce

1. Clone this repository.
2. Open `bug.fs` in an F# editor.
3. Run the `loop` function. You will observe that it runs indefinitely.
4. Compare this with the corrected code in `bugSolution.fs`.