import Api from '@/api'

export default {
    async install(app, global) {
        const preloads = await Promise.all([
            (async () => {
                try {
                    return await Api.sys_menu.userMenus.post()
                } catch {
                    //
                }
            })(),
            (async () => {
                try {
                    return await Api.sys_user.userInfo.post()
                } catch {
                    //
                }
            })(),
            (async () => {
                try {
                    return await Api.sys_constant.getEnums.post()
                } catch {
                    //
                }
            })(),
            (async () => {
                try {
                    return await Api.sys_constant.getNumbers.post()
                } catch {
                    //
                }
            })(),
            (async () => {
                try {
                    return await Api.sys_constant.getChars.post()
                } catch {
                    //
                }
            })(),
        ])

        if (!global) global = app.config.globalProperties.$GLOBAL
        global.menu = preloads[0]?.data
        global.user = preloads[1]?.data
        global.enums = preloads[2]?.data
        global.numbers = preloads[3]?.data
        global.chars = preloads[4]?.data
    },
}