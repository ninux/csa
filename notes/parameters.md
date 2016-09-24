[return](./README)

# Parameters
---

## value parameter
```C#
public int a = 1
public int b = 2;
public int c = 3;

public int Add(int arg1, int arg2)
{
	int res;

	res = arg1 + arg2;

	return res;
}
```
The method `Add()` gets the variables `a`, `b`, `c` on its own stack.
The method reads them from there and writes them there.

## ref parameter
The class `A` defines a method `Add()` like this
```C#
public int Add(ref int arg1, ref int arg2)
{
	int res;

	res = arg1 + arg2; 

	return res;
}
```
and a program call it like this
```C#
int a = 1;
int b = 2;
int c = 3;

c = add(ref a, ref b)
```
The method `Add()` gets the parameters as a reference (not on its stack).
This is done by the keyword `ref` which has to be declared at the
method definition as well as at the method call. The result however
is again written on a variable (`return`).

## out parameter
tbd
