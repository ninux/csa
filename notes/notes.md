[return](./../README.md)

# Notes
---

## Invoke base constructor

```
public class A
{
	public A(string msg);
}

public class B : A
{
	public B(string msg, int ctr) : this(msg)
	{
		// ...
	}

	public B(string msg) : this(msg, 5)

	public B() : this("hello", 5)
}
```
