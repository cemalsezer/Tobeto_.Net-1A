import React from 'react'
import { Dropdown, MenuItem,DropdownMenu,Image } from 'semantic-ui-react'

export default function SignedIn({singOut}) {
  return (
    <div>
           <MenuItem>
                <Image avatar spaced="right" src="https://avatars.githubusercontent.com/u/69629934?v=4" />
                <Dropdown pointing="top right" text='cemal'>
                    <DropdownMenu>
                        <Dropdown.Item text="Bilgilerim" icon="info" />
                        <Dropdown.Item onClick={singOut} text="Çıkış yap" icon="sing-out" />
                    </DropdownMenu>
                </Dropdown>
            </MenuItem>
    </div>
  )
}
