----------------------------------------------------------------------
-----------------------------程序入口---------------------------------
----------------------------------------------------------------------

print("Lua版本", _VERSION)


-- require "lfs"

-- package.path = lfs.currentdir() .. [=[/?.lua]=]
print(package.path)

require("tools.functions")

print_t("main", "lua")








