[return](./README.md)

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
and a program calls it like this
```C#
int a = 1;
int b = 2;
int c = 3;

c = add(ref a, ref b)
```
The method `Add()` gets the parameters as a reference (not on its stack).
This is done by the keyword `ref` which has to be declared at the
method definition as well as at the method call. The result however
is again written on a variable. This is done as usual by the
`return` statements and the `int` return type at the method declaration.

## out parameter
The `out` modifier is similar to the `ref` modifier. The difference is
that it not just references the variable, it writes it by the method.

The class `A` defines a method `Add()` like this
```C#
public void Add(out int res, ref int arg1, ref int arg2)
{
	res = arg1 + arg2;
}
```
and a program calls it like this
```C#
int a = 1;
int b = 2;
int c = 3;

Add(out c, ref a, ref b);
```
The method writes the variable `c` without using the classic form
`c = Add(...)`. The arguments 1 and 2 are again given by reference
because the method just reads them. The result on the other hand has
to be written and therefore it's declared with `out` in the parameter
list.

A obvious thing is that the parameters modified by `ref` must be
initialised whereas parameters modified with `out` do not have to be
initialised (they can be initilised).
