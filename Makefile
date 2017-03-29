all:
	$(MAKE) -C v2.0
	$(MAKE) -C v3.5
	$(MAKE) -C v4.0
	$(MAKE) -C v4.5
	$(MAKE) -C v4.5.1
	$(MAKE) -C v4.5.2
	$(MAKE) -C v4.6
	$(MAKE) -C v4.6.1
	$(MAKE) -C v4.6.2

clean:
	$(MAKE) -C v2.0 clean
	$(MAKE) -C v3.5 clean
	$(MAKE) -C v4.0 clean
	$(MAKE) -C v4.5 clean
	$(MAKE) -C v4.5.1 clean
	$(MAKE) -C v4.5.2 clean
	$(MAKE) -C v4.6 clean
	$(MAKE) -C v4.6.1 clean
	$(MAKE) -C v4.6.2 clean

.PHONY: all clean
